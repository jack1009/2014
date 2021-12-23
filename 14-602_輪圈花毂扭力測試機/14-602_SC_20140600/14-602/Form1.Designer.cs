namespace _14_602
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                tcd.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_MaxValue = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_Time = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_Date = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_BarCodeNo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_TestResult = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pb_Fix_SOL = new System.Windows.Forms.Button();
            this.pb_MotorStart = new System.Windows.Forms.Button();
            this.pb_Setup = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_StandValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TestTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TestSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_PreTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_PreSpeed = new System.Windows.Forms.TextBox();
            this.pb_PreTurnEnable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tb_300g = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_100g = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_Mask = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_400g = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_200g = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_VoltValue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_TorqueCurrentValue = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_TorqueSetValue = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 606);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Green;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1143, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "主畫面";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.tb_MaxValue);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.tb_Time);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.tb_Date);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.tb_BarCodeNo);
            this.groupBox5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(8, 332);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(1124, 237);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DATA";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(539, 194);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(163, 24);
            this.label13.TabIndex = 10;
            this.label13.Text = "g-cm(+-20g-cm)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 9;
            this.label12.Text = "最大扭力值";
            // 
            // tb_MaxValue
            // 
            this.tb_MaxValue.AcceptsTab = true;
            this.tb_MaxValue.Location = new System.Drawing.Point(155, 190);
            this.tb_MaxValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_MaxValue.Name = "tb_MaxValue";
            this.tb_MaxValue.Size = new System.Drawing.Size(375, 36);
            this.tb_MaxValue.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(543, 145);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "時間";
            // 
            // tb_Time
            // 
            this.tb_Time.AcceptsTab = true;
            this.tb_Time.Location = new System.Drawing.Point(613, 141);
            this.tb_Time.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Time.Name = "tb_Time";
            this.tb_Time.Size = new System.Drawing.Size(451, 36);
            this.tb_Time.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 145);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 24);
            this.label10.TabIndex = 5;
            this.label10.Text = "日期";
            // 
            // tb_Date
            // 
            this.tb_Date.AcceptsTab = true;
            this.tb_Date.Location = new System.Drawing.Point(155, 141);
            this.tb_Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Date.Name = "tb_Date";
            this.tb_Date.Size = new System.Drawing.Size(375, 36);
            this.tb_Date.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "BarCode No.";
            // 
            // tb_BarCodeNo
            // 
            this.tb_BarCodeNo.AcceptsTab = true;
            this.tb_BarCodeNo.Location = new System.Drawing.Point(155, 36);
            this.tb_BarCodeNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_BarCodeNo.Multiline = true;
            this.tb_BarCodeNo.Name = "tb_BarCodeNo";
            this.tb_BarCodeNo.Size = new System.Drawing.Size(909, 83);
            this.tb_BarCodeNo.TabIndex = 0;
            this.tb_BarCodeNo.TextChanged += new System.EventHandler(this.tb_BarCodeNo_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lb_TestResult);
            this.groupBox4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(945, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(187, 318);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "測試結果";
            // 
            // lb_TestResult
            // 
            this.lb_TestResult.AutoSize = true;
            this.lb_TestResult.BackColor = System.Drawing.Color.Green;
            this.lb_TestResult.Font = new System.Drawing.Font("新細明體", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lb_TestResult.Location = new System.Drawing.Point(17, 32);
            this.lb_TestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TestResult.Name = "lb_TestResult";
            this.lb_TestResult.Size = new System.Drawing.Size(142, 80);
            this.lb_TestResult.TabIndex = 0;
            this.lb_TestResult.Text = "OK";
            this.lb_TestResult.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(929, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "測試圖表";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(8, 26);
            this.chart1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chart1.Name = "chart1";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "扭力值";
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(913, 284);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Green;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.pb_Setup);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1143, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "參數設定";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.pb_Fix_SOL);
            this.groupBox6.Controls.Add(this.pb_MotorStart);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(585, 225);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(547, 210);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "手動";
            // 
            // pb_Fix_SOL
            // 
            this.pb_Fix_SOL.ForeColor = System.Drawing.Color.Black;
            this.pb_Fix_SOL.Location = new System.Drawing.Point(196, 36);
            this.pb_Fix_SOL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Fix_SOL.Name = "pb_Fix_SOL";
            this.pb_Fix_SOL.Size = new System.Drawing.Size(179, 46);
            this.pb_Fix_SOL.TabIndex = 11;
            this.pb_Fix_SOL.Text = "固定氣缸";
            this.pb_Fix_SOL.UseVisualStyleBackColor = true;
            this.pb_Fix_SOL.Click += new System.EventHandler(this.pb_Fix_SOL_Click);
            // 
            // pb_MotorStart
            // 
            this.pb_MotorStart.ForeColor = System.Drawing.Color.Black;
            this.pb_MotorStart.Location = new System.Drawing.Point(8, 36);
            this.pb_MotorStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_MotorStart.Name = "pb_MotorStart";
            this.pb_MotorStart.Size = new System.Drawing.Size(179, 46);
            this.pb_MotorStart.TabIndex = 10;
            this.pb_MotorStart.Text = "馬達啟動";
            this.pb_MotorStart.UseVisualStyleBackColor = true;
            this.pb_MotorStart.Click += new System.EventHandler(this.pb_MotorStart_Click);
            // 
            // pb_Setup
            // 
            this.pb_Setup.ForeColor = System.Drawing.Color.Black;
            this.pb_Setup.Location = new System.Drawing.Point(4, 452);
            this.pb_Setup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Setup.Name = "pb_Setup";
            this.pb_Setup.Size = new System.Drawing.Size(179, 46);
            this.pb_Setup.TabIndex = 9;
            this.pb_Setup.Text = "設定";
            this.pb_Setup.UseVisualStyleBackColor = true;
            this.pb_Setup.Click += new System.EventHandler(this.pb_Setup_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_StandValue);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_TestTime);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_TestSpeed);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(585, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(551, 210);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "測試選項";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(383, 129);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 24);
            this.label15.TabIndex = 10;
            this.label15.Text = "g-cm(100~400)";
            // 
            // tb_StandValue
            // 
            this.tb_StandValue.Location = new System.Drawing.Point(187, 121);
            this.tb_StandValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_StandValue.Name = "tb_StandValue";
            this.tb_StandValue.Size = new System.Drawing.Size(187, 36);
            this.tb_StandValue.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 129);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "測試標準值:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "秒(1~30)";
            // 
            // tb_TestTime
            // 
            this.tb_TestTime.Location = new System.Drawing.Point(187, 76);
            this.tb_TestTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TestTime.Name = "tb_TestTime";
            this.tb_TestTime.Size = new System.Drawing.Size(187, 36);
            this.tb_TestTime.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "測試時間:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "RPM(10~30)";
            // 
            // tb_TestSpeed
            // 
            this.tb_TestSpeed.Location = new System.Drawing.Point(187, 31);
            this.tb_TestSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TestSpeed.Name = "tb_TestSpeed";
            this.tb_TestSpeed.Size = new System.Drawing.Size(187, 36);
            this.tb_TestSpeed.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "測試轉速:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_PreTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_PreSpeed);
            this.groupBox1.Controls.Add(this.pb_PreTurnEnable);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(569, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "預轉選項";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "秒(0.1~9.9)";
            // 
            // tb_PreTime
            // 
            this.tb_PreTime.Location = new System.Drawing.Point(187, 135);
            this.tb_PreTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PreTime.Name = "tb_PreTime";
            this.tb_PreTime.Size = new System.Drawing.Size(187, 36);
            this.tb_PreTime.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "預轉時間:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "RPM(50~60)";
            // 
            // tb_PreSpeed
            // 
            this.tb_PreSpeed.Location = new System.Drawing.Point(187, 90);
            this.tb_PreSpeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_PreSpeed.Name = "tb_PreSpeed";
            this.tb_PreSpeed.Size = new System.Drawing.Size(187, 36);
            this.tb_PreSpeed.TabIndex = 3;
            // 
            // pb_PreTurnEnable
            // 
            this.pb_PreTurnEnable.ForeColor = System.Drawing.Color.Black;
            this.pb_PreTurnEnable.Location = new System.Drawing.Point(8, 36);
            this.pb_PreTurnEnable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_PreTurnEnable.Name = "pb_PreTurnEnable";
            this.pb_PreTurnEnable.Size = new System.Drawing.Size(179, 46);
            this.pb_PreTurnEnable.TabIndex = 0;
            this.pb_PreTurnEnable.Text = "預轉使用";
            this.pb_PreTurnEnable.UseVisualStyleBackColor = true;
            this.pb_PreTurnEnable.Click += new System.EventHandler(this.pb_PreTurnEnable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "預轉轉速:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Green;
            this.tabPage3.Controls.Add(this.groupBox9);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1143, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "扭力檢驗";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tb_300g);
            this.groupBox9.Controls.Add(this.label24);
            this.groupBox9.Controls.Add(this.tb_100g);
            this.groupBox9.Controls.Add(this.label23);
            this.groupBox9.Controls.Add(this.tb_Mask);
            this.groupBox9.Controls.Add(this.label22);
            this.groupBox9.Controls.Add(this.tb_400g);
            this.groupBox9.Controls.Add(this.label25);
            this.groupBox9.Controls.Add(this.tb_200g);
            this.groupBox9.Controls.Add(this.label27);
            this.groupBox9.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.Location = new System.Drawing.Point(4, 250);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(569, 291);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "校驗設定(非校驗人員勿更動)";
            // 
            // tb_300g
            // 
            this.tb_300g.Location = new System.Drawing.Point(187, 120);
            this.tb_300g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_300g.Name = "tb_300g";
            this.tb_300g.Size = new System.Drawing.Size(187, 36);
            this.tb_300g.TabIndex = 21;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(11, 128);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(60, 24);
            this.label24.TabIndex = 20;
            this.label24.Text = "300g:";
            // 
            // tb_100g
            // 
            this.tb_100g.Location = new System.Drawing.Point(187, 30);
            this.tb_100g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_100g.Name = "tb_100g";
            this.tb_100g.Size = new System.Drawing.Size(187, 36);
            this.tb_100g.TabIndex = 19;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(11, 38);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 24);
            this.label23.TabIndex = 18;
            this.label23.Text = "100g:";
            // 
            // tb_Mask
            // 
            this.tb_Mask.Location = new System.Drawing.Point(187, 210);
            this.tb_Mask.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_Mask.Name = "tb_Mask";
            this.tb_Mask.Size = new System.Drawing.Size(187, 36);
            this.tb_Mask.TabIndex = 17;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(11, 218);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 24);
            this.label22.TabIndex = 16;
            this.label22.Text = "系數修正值:";
            // 
            // tb_400g
            // 
            this.tb_400g.Location = new System.Drawing.Point(187, 165);
            this.tb_400g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_400g.Name = "tb_400g";
            this.tb_400g.Size = new System.Drawing.Size(187, 36);
            this.tb_400g.TabIndex = 6;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(11, 172);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 24);
            this.label25.TabIndex = 5;
            this.label25.Text = "400g:";
            // 
            // tb_200g
            // 
            this.tb_200g.Location = new System.Drawing.Point(187, 75);
            this.tb_200g.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_200g.Name = "tb_200g";
            this.tb_200g.Size = new System.Drawing.Size(187, 36);
            this.tb_200g.TabIndex = 3;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(11, 82);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 24);
            this.label27.TabIndex = 2;
            this.label27.Text = "200g:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.tb_VoltValue);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.button3);
            this.groupBox7.Controls.Add(this.button2);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.tb_TorqueCurrentValue);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.tb_TorqueSetValue);
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox7.ForeColor = System.Drawing.Color.White;
            this.groupBox7.Location = new System.Drawing.Point(4, 4);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(569, 239);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "扭力檢驗";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(399, 188);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 24);
            this.label20.TabIndex = 15;
            this.label20.Text = "V";
            // 
            // tb_VoltValue
            // 
            this.tb_VoltValue.Location = new System.Drawing.Point(187, 180);
            this.tb_VoltValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_VoltValue.Name = "tb_VoltValue";
            this.tb_VoltValue.Size = new System.Drawing.Size(187, 36);
            this.tb_VoltValue.TabIndex = 14;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 188);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 24);
            this.label21.TabIndex = 13;
            this.label21.Text = "目前檢測電壓:";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(201, 36);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 46);
            this.button3.TabIndex = 12;
            this.button3.Text = "固定氣缸";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(383, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 46);
            this.button2.TabIndex = 10;
            this.button2.Text = "設定";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(16, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "馬達啟動";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pb_MotorStart_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(399, 142);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 24);
            this.label16.TabIndex = 7;
            this.label16.Text = "g-cm";
            // 
            // tb_TorqueCurrentValue
            // 
            this.tb_TorqueCurrentValue.Location = new System.Drawing.Point(187, 135);
            this.tb_TorqueCurrentValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TorqueCurrentValue.Name = "tb_TorqueCurrentValue";
            this.tb_TorqueCurrentValue.Size = new System.Drawing.Size(187, 36);
            this.tb_TorqueCurrentValue.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(11, 142);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 24);
            this.label17.TabIndex = 5;
            this.label17.Text = "目前檢測扭力:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(399, 98);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "kg-cm(0~2.5)";
            // 
            // tb_TorqueSetValue
            // 
            this.tb_TorqueSetValue.Location = new System.Drawing.Point(187, 90);
            this.tb_TorqueSetValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_TorqueSetValue.Name = "tb_TorqueSetValue";
            this.tb_TorqueSetValue.Size = new System.Drawing.Size(187, 36);
            this.tb_TorqueSetValue.TabIndex = 3;
            this.tb_TorqueSetValue.Text = "2.5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 98);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(160, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "出力扭力設定:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 625);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_PreTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_PreSpeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TestTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_TestSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_BarCodeNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_Time;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_MaxValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button pb_Setup;
        private System.Windows.Forms.Button pb_PreTurnEnable;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button pb_MotorStart;
        private System.Windows.Forms.Label lb_TestResult;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_StandValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_TorqueCurrentValue;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_TorqueSetValue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button pb_Fix_SOL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tb_400g;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_200g;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_VoltValue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_Mask;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_300g;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_100g;
        private System.Windows.Forms.Label label23;

    }
}

