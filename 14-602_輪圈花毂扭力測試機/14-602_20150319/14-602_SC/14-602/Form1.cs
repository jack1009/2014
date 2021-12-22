using System;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Automation.BDaq;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Configuration;
using System.Globalization;

namespace _14_602
{
    public partial class Form1 : Form
    {
        int testtimetick = 150;                 //測試時間間隔
        int ShowUICount;
        bool pciRunning;                        //PCI卡狀態
        bool MachineRunning;                    //自動啟動狀態
        bool recording;                         //記錄狀態
        bool OkFlag;                            //測試結果
        bool BreakFlag;                         //測試中斷
        double MaxTestValue;                    //最大值
        double MinTestValue;                    //最小值
        int[,] input=new int[2,8];              //Input,2個PORT,每個PORT有8Bits
        int[,] outputStatus = new int[2, 8];    //Output目前狀態,2個PORT,每個PORT有8Bits
        byte[] outputCommand = new byte[2];     //Output命令狀態,2個PORT,每個PORT有8Bits
        double[] aiInput = new double[16];      //類比輸入值,16個channels
        double[] aiInputVolt = new double[16];
        double[] recordData;
        List<double> MinArry;   //給取最小值用的
        Thread poolingThread;                   //pooling DIO,和AI執行緒
        Thread MachineRunThread;                //設備主程式執行緒
        TestConditionDataContext tcd;           //Linq
        TestCondition tc;                       //Linq
        string BarcodeRecord;                   //前次BARCODE記憶
        Product p;
        DeltaServoComm ServoMotor_Test;         //伺服馬達宣告
        delegate void mydelegate();
        double TorqueOldValue=0.0;
        double TorqueNewValue=0.0;
        const double Gear = 0.06;
        double[] x=new double[4];
        double[] a=new double[4];
        double[] b=new double[4];
        double MaskValue;

        public Form1()
        {
            InitializeComponent();
            this.button3.Click += new System.EventHandler(this.pb_Fix_SOL_Click);
        }

        //Form1載入
        private void Form1_Load(object sender, EventArgs e)
        {
            pciRunning = false;     //PCI卡狀態
            MachineRunning = false;    //自動狀態
            recording = false;
            BreakFlag = false;
            //OutputSet(0, 2);        //轉距命令bit0*****************最後移除註解
            try
            {
                //建立測試參數
                tcd = new TestConditionDataContext();
                tc = (from x in tcd.TestCondition where x.id == 1 select x).First();
                TestConditionShow();
                setTuningValue();
                //建立對伺服馬達的通訊
                ServoMotor_Test = new DeltaServoComm();
                ServoMotor_Test.CreateSerialPort("COM1");
                ServoMotor_Test.OpenComport();
                //伺服馬達參數不寫入EEPROM
                ServoMotor_Test.SendDataToServo16(0x01, 0x023C, 5);   
                Thread.Sleep(15);
                //設定speed0的速度
                ServoMotor_Test.SendDataToServo32(0x01, 0x0112, (tc.PreTurnSpeed * 10));
                //傳輸間要靜默15ms
                Thread.Sleep(15);
                //設定speed1的速度
                ServoMotor_Test.SendDataToServo32(0x01, 0x0114, (tc.TestSpeed * 10));
                Thread.Sleep(15);
                ServoMotor_Test.SendDataToServo16(0x01, 0x014E, Convert.ToByte(tc.TestSpeed));
                Thread.Sleep(15);
                ServoMotor_Test.SendDataToServo16(0x01, 0x118, Convert.ToInt16(tc.TorqueValue / 3.2 * 100));
                Thread.Sleep(15);
            }
            catch (Exception)
            {
                MessageBox.Show("系統未完成準備,請關閉程式後重新啟動");
            }
            
            //建立執行緒,輪詢DIO,AI狀態
            ThreadStart ts = new ThreadStart(InstantDio);
            poolingThread = new Thread(ts);
            poolingThread.IsBackground = true;
            pciRunning = true;
            poolingThread.Start();
            //建立執行緒,設備主程式
            MachineRunThread = new Thread(MachineRun);
            MachineRunThread.IsBackground = true;
            MachineRunning = true;
            MachineRunThread.Start();
        }

        ////UI啟動後把焦點放在BARCORD的TEXT上
        private void Form1_Activated(object sender, EventArgs e)
        {
            this.tb_BarCodeNo.Focus();
        }

        //show測試值
        private void TestConditionShow()
        {
            PreTurnButtonTextChange(tc);
            tb_PreSpeed.Text = tc.PreTurnSpeed.ToString();
            tb_PreTime.Text = tc.PreTurnTime.ToString();
            tb_TestSpeed.Text = tc.TestSpeed.ToString();
            tb_TestTime.Text = tc.TestTime.ToString();
            tb_StandValue.Text = tc.StandarValue.ToString();
            tb_TorqueSetValue.Text = tc.TorqueValue.ToString();
            tb_100g.Text = tc._100gValue.ToString();
            tb_200g.Text = tc._200gValue.ToString();
            tb_300g.Text = tc._300gValue.ToString();
            tb_400g.Text = tc._400gValue.ToString();
            tb_Mask.Text = tc.MaskValue.ToString();
        }

        //預轉使用與不使用,UI顯示
        private void PreTurnButtonTextChange(TestCondition tc)
        {
            if (tc.PreTurnEnable ==0)
            {
                pb_PreTurnEnable.Text = "預轉不使用";
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                tb_PreSpeed.Visible = false;
                tb_PreTime.Visible = false;
            }
            else
            {
                pb_PreTurnEnable.Text = "預轉使用";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                tb_PreSpeed.Visible = true;
                tb_PreTime.Visible = true;
            }
        }

        //預轉使用與不使用設定
        private void pb_PreTurnEnable_Click(object sender, EventArgs e)
        {
            if (tc.PreTurnEnable==0)
            {
                tc.PreTurnEnable = 1;
            }
            else
            {
                tc.PreTurnEnable = 0;
            }
            PreTurnButtonTextChange(tc);
            tcd.SubmitChanges();
        }

        //測試值設定
        private void pb_Setup_Click(object sender, EventArgs e)
        {
            //儲存測試參數
            tc.PreTurnSpeed = CheckPreTurnSpeedValue(Convert.ToInt32(tb_PreSpeed.Text));
            tc.PreTurnTime = CheckPreTurnTimeValue(Convert.ToDouble(tb_PreTime.Text));
            tc.TestSpeed = CheckTestTurnSpeedValue(Convert.ToInt32(tb_TestSpeed.Text));
            tc.TestTime = CheckTestTurnTimeValue(Convert.ToDouble(tb_TestTime.Text));
            tc.StandarValue = Convert.ToDouble(tb_StandValue.Text);
            TestConditionShow();
            tcd.SubmitChanges();

            //設定speed0的速度
            ServoMotor_Test.SendDataToServo32(0x01, 0x0112, (tc.PreTurnSpeed * 10));
            //傳輸間要靜默10ms
            Thread.Sleep(15);
            //設定speed1的速度
            ServoMotor_Test.SendDataToServo32(0x01, 0x0114, (tc.TestSpeed * 10));
            Thread.Sleep(15);
            //設定目標速度
            ServoMotor_Test.SendDataToServo16(1, 0x014E, Convert.ToByte(tc.TestSpeed));
        }

        //測試值的檢查
        private int CheckPreTurnSpeedValue(int condition)
        {
            if (condition>=50 && condition <=60)
            {
                return condition;
            }
            else
            {
                MessageBox.Show("測試值設定超出範圍");
                return 0;
            }
        }

        //測試值的檢查
        private int CheckTestTurnSpeedValue(int condition)
        {
            if (condition >= 1 && condition <= 30)
            {
                return condition;
            }
            else
            {
                MessageBox.Show("測試值設定超出範圍");
                return 0;
            }
        }

        //測試值的檢查
        private double CheckPreTurnTimeValue(double condition)
        {
            if (condition >= 0.1 && condition <= 9.9)
            {
                return condition;
            }
            else
            {
                MessageBox.Show("測試值設定超出範圍");
                return 0.0;
            }
        }

        //測試值的檢查
        private double CheckTestTurnTimeValue(double condition)
        {
            if (condition >= 1.0 && condition <= 60.0)
            {
                return condition;
            }
            else
            {
                MessageBox.Show("測試值設定超出範圍");
                return 0.0;
            }
        }

        //PCI卡輪詢方法
        private void InstantDio()
        {
            int deviceNumber = 0;
            int startPort = 0;
            int portCount = 2;
            BDaqDevice device = null;
            BDaqDio dio = null;
            BDaqAi ai = null;
            ErrorCode ret;

            //open device with write access
            ret = BDaqDevice.Open(deviceNumber, AccessMode.ModeWrite, out device);

            //get Dio module
            ret = device.GetModule(0, out dio);

            //get Ai module
            ret = device.GetModule(0, out ai);

            // set the parameters (not necessary)
            int chCount;
            ret = ai.Property.Get(PropertyId.CFG_FeatureChannelNumberMax, out chCount);
            chCount += 1;

            //buffer
            byte[] bufferForDiReading = new Byte[64];
            byte[] bufferForDoReading = new Byte[64];
            byte[] bufferForDoWriting = new Byte[64];
            double[] scaledData = new double[chCount];
            int[] rawData =new int[chCount];

            //int channelOffset = 0;
            ret = ai.BfdAiRunOnce(false);    // Start buffered AI in synchronous
            
            //Read DIO ports status
            while (pciRunning)
            {
                ret = ai.Read(0, 16, scaledData);
                ret = dio.DiRead(startPort, portCount, bufferForDiReading);
                ret = dio.DoRead(startPort, portCount, bufferForDoReading);
                for (int i = 0; i < chCount; i++)
                {
                    if (scaledData[i] <= x[0])
                    {
                        aiInput[i] = Math.Round(scaledData[i],2) * a[0]+b[0];
                    }
                    if (scaledData[i] > x[0] & scaledData[i] <= x[1])
                    {
                        aiInput[i] = Math.Round(scaledData[i], 2) * a[1] + b[1];
                    }
                    if (scaledData[i] > x[1] & scaledData[i] <= x[2])
                    {
                        aiInput[i] = Math.Round(scaledData[i], 2) * a[2] + b[2];
                    }
                    if (scaledData[i] > x[2])
                    {
                        aiInput[i] = Math.Round(scaledData[i], 2) * a[3] + b[3];
                    }
                    aiInputVolt[i] = Math.Round(scaledData[i],2);
                }

                for (int i = 0; i < portCount; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        input[i, j] = (bufferForDiReading[i] & (0x01 << j)) >> j;
                        outputStatus[i, j] = (bufferForDoReading[i] & (0x01 << j)) >> j;
                    }
                    bufferForDoWriting[i] = outputCommand[i];
                }
                ret = dio.DoWrite(startPort, portCount, bufferForDoWriting);

                TorqueNewValue = aiInput[0];
                TorqueOldValue = (TorqueNewValue - TorqueOldValue) * Gear + TorqueOldValue;
               
                Thread.Sleep(5);
            }

            if (device != null)
            {
                ret = ai.BfdAiRelease();    // release the buffered AI
                device.Close();//Close the device
            }
        }

        //Output驅動方法
        private void OutputSet(byte port,byte bit)
        {
            outputCommand[port] = Convert.ToByte(outputCommand[port] | (0x01 << bit));
        }

        //Output驅動方法
        private void OutputReset(byte port, byte bit)
        {
            outputCommand[port] = Convert.ToByte(outputCommand[port] & (~(0x01 << bit)));
        }

        //馬達啟動_手動
        private void pb_MotorStart_Click(object sender, EventArgs e)
        {
            if (outputStatus[0, 6] == 0)
            {
                OutputSet(0, 6);
            }
            else
            {
                OutputReset(0, 6);
            }
            if (outputStatus[0, 2] == 0)
            {
                OutputSet(0, 2);
            }
            else
            {
                OutputReset(0, 2);
            }
        }

        //************************************************************
        //設備主程式
        private void MachineRun()
        {
            while (MachineRunning)
            {
                if (input[1,0]==1)  //啟動鍵按下
                {
                    //清除UI
                    mydelegate md4 = new mydelegate(ClearUI);
                    this.Invoke(md4);

                    OkFlag = true;
                    if (tb_BarCodeNo.Text!="" && tb_BarCodeNo.Text!=BarcodeRecord)      //判有無條碼
                    {
                        //建立資料
                        mydelegate md2 = new mydelegate(ShowConditionToUI);
                        this.Invoke(md2);
                        OutputSet(1, 7);
                        Thread.Sleep(1000);
                        if (tc.PreTurnEnable == 1)      //判有無預轉
                        {
                            PreTurnFlow();  //預轉開始
                            TestFlow();     //測試開始
                        }
                        else
                        {
                            TestFlow();     //測試開始
                        }
                    }
                    else
                    {
                        if (tb_BarCodeNo.Text==BarcodeRecord)
                        {
                            MessageBox.Show("條碼與前一筆重覆!!");
                        }
                        else
                        {
                            MessageBox.Show("條碼未取得!!");
                        }
                    }
                    
                }
                if (BreakFlag==true)
                {
                    MessageBox.Show("測試中斷");
                    BreakFlag = false;
                }

                //顯示torque現值
                try
                {
                    mydelegate md5 = new mydelegate(showTorqueValue);
                    this.Invoke(md5);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
                
            }
        }

        //預轉流程
        private void PreTurnFlow()
        {
            OutputSet(0, 5);    //預轉開始
            OutputSet(0, 2);
            Thread.Sleep(Convert.ToInt32(tc.PreTurnTime * 1000));
        }

        //測試流程
        private void TestFlow()
        {
            recordData = new double[Convert.ToInt32(tc.TestTime) * 1000 / testtimetick];
            MinArry = new List<double>();
            OutputSet(0, 2);
            OutputReset(0, 5);
            OutputSet(0, 6);
 
            //while (input[0, 2] == 0)   //馬達轉速到達
            //{
            //    if (input[1,1]==1)
            //    {
            //        BreakFlag = true;
            //        break;
            //    }
            //}
            //Thread.Sleep(10);
            if (BreakFlag==false)
            {
                recording = true;
                while (recording == true)
                {
                    ShowUICount = 0;
                    while (ShowUICount < Convert.ToInt32(tc.TestTime) * 1000 / testtimetick)
                    {
                        if (TorqueOldValue>=MaskValue)
                        {
                            recordData[ShowUICount] = TorqueOldValue - MaskValue;   
                        }
                        else
                        {
                            recordData[ShowUICount] = 0;   
                        }
                        if (ShowUICount >= Convert.ToInt32(tc.TestTime) * 1000 / testtimetick/4)
                        {
                            MinArry.Add(recordData[ShowUICount]);
                            MinTestValue = MinArry.Min();    //取最小值    
                        }
                        MaxTestValue = recordData.Max();    //取最大值
                        mydelegate md = new mydelegate(showUI);
                        this.Invoke(md);
                        if (MaxTestValue > tc.StandarValue)
                        {
                            recording = false;
                            OkFlag = false;
                            break;
                        }
                        if (input[1, 1] == 1)
                        {
                            BreakFlag = true;
                            break;
                        }
                        Thread.Sleep(testtimetick);
                    }
                    recording = false;
                    mydelegate md3 = new mydelegate(showUI);
                    this.Invoke(md3);
                }
                OutputReset(0, 6);
                OutputReset(0, 2);
                OutputReset(1, 7);
                p.MaxValue = MaxTestValue.ToString("####", CultureInfo.InvariantCulture);
                BarcodeRecord = p.BarcodeNo;
                if (OkFlag && !BreakFlag)
                {
                    p.WriteToExcelFile(p.BarcodeNo, p.Date, p.Time, p.MaxValue);    //測試OK寫入EXCEL
                }
            }
            
        }

        //************************************************************
        private void showTorqueValue()
        {
            //TorqueNewValue = aiInput[0];
            //TorqueOldValue = (TorqueNewValue - TorqueOldValue) * Gear + TorqueOldValue;
            tb_TorqueCurrentValue.Text = TorqueOldValue.ToString("####", CultureInfo.InvariantCulture);
            //tb_TorqueCurrentValue.Text = TorqueOldValue.ToString("####", CultureInfo.InvariantCulture);
            tb_VoltValue.Text = aiInputVolt[0].ToString();
        }
        //************************************************************

        private void showUI()
        {
            if (recording==true)
            {
                chart1.Series[0].Points.AddY(recordData[ShowUICount]);
                tb_MaxValue.Text = MaxTestValue.ToString("####",CultureInfo.InvariantCulture);

                tb_MinValue.Text = MinTestValue.ToString("####", CultureInfo.InvariantCulture);
            }
            else
            {
                if (OkFlag && !BreakFlag)
                {
                    lb_TestResult.Text = "OK";
                    lb_TestResult.BackColor = Color.Green;
                    groupBox4.BackColor = Color.Green;
                    lb_TestResult.Visible = true;
                }
                else
                {
                    lb_TestResult.Text = "NG";
                    lb_TestResult.BackColor = Color.Red;
                    groupBox4.BackColor = Color.Red;
                    lb_TestResult.Visible = true;
                }
            }
            ShowUICount++;
        }

        //UI顯示BARCODE資訊
        private void ShowConditionToUI()
        {
            p = new Product();
            p.BarcodeNo = tb_BarCodeNo.Text;
            p.Date = DateTime.Now.ToShortDateString();
            p.Time = DateTime.Now.ToShortTimeString();
            tb_Date.Text = p.Date;
            tb_Time.Text = p.Time;
            tb_BarCodeNo.SelectAll();
        }

        //清除UI
        private void ClearUI()
        {
            lb_TestResult.Visible = false;
            groupBox4.BackColor = Color.Green;
            tb_Date.Text = "";
            tb_Time.Text = "";
            tb_MaxValue.Text = "";
            tb_MinValue.Text = "";
            lb_TestResult.Visible = false;
            chart1.Series[0].Points.Clear();
        }

        //掃BARCODE事件
        private void tb_BarCodeNo_TextChanged(object sender, EventArgs e)
        {
            lb_TestResult.Visible = false;
            groupBox4.BackColor = Color.Green;
            tb_Date.Text = "";
            tb_Time.Text = "";
            tb_MaxValue.Text = "";
            tb_MinValue.Text = "";
            lb_TestResult.Visible = false;
            chart1.Series[0].Points.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MachineRunning = false;
            pciRunning = false;
            ServoMotor_Test.CloseComport();
            this.Dispose();
        }

        //轉距設定
        private void button2_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(tb_TorqueSetValue.Text)<=2.5)&&(Convert.ToDouble(tb_TorqueSetValue.Text)>=0.0))
            {
                ServoMotor_Test.SendDataToServo16(0x01, 0x118, Convert.ToInt16(Convert.ToDouble(tb_TorqueSetValue.Text) / 3.2 * 100));
                Thread.Sleep(15);
                tc.TorqueValue = Convert.ToDouble(tb_TorqueSetValue.Text);
                tcd.SubmitChanges();
            }
            else
            {
                tb_TorqueSetValue.Text = "2.5";
                MessageBox.Show("超出設定範圍");
            }
            tc._100gValue = Convert.ToDouble(tb_100g.Text);
            tc._200gValue = Convert.ToDouble(tb_200g.Text);
            tc._300gValue = Convert.ToDouble(tb_300g.Text);
            tc._400gValue = Convert.ToDouble(tb_400g.Text);
            tc.MaskValue = Convert.ToDouble(tb_Mask.Text);
            tcd.SubmitChanges();
            setTuningValue();
        }

        //固定氣缸
        private void pb_Fix_SOL_Click(object sender, EventArgs e)
        {
            if (outputStatus[1,7] == 0)
            {
                OutputSet(1,7);
            }
            else
            {
                OutputReset(1,7);
            }
        }

        //復歸
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (byte i = 0; i < 2; i++)
            {
                for (byte j = 0; j < 8; j++)
                {
                    OutputReset(i, j);
                }
            }
        }

        //設定校正
        private void setTuningValue()
        {
            x[0] = Convert.ToDouble(tc._100gValue);
            x[1] = Convert.ToDouble(tc._200gValue);
            x[2] = Convert.ToDouble(tc._300gValue);
            x[3] = Convert.ToDouble(tc._400gValue);
            a[0] = (100.0 - 0.0) / (x[0] - 0.0);
            a[1] = (200.0 - 100.0) / (x[1] - x[0]);
            a[2] = (300.0 - 200.0) / (x[2] - x[1]);
            a[3] = (400.0 - 300.0) / (x[3] - x[2]);
            b[0] = 100.0 - a[0] * x[0];
            b[1] = 200.0 - a[1] * x[1];
            b[2] = 300.0 - a[2] * x[2];
            b[3] = 400.0 - a[3] * x[3];
            MaskValue = Convert.ToDouble(tc.MaskValue);
        }
    }
}
