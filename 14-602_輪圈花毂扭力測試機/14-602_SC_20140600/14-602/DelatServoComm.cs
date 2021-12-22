using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace _14_602
{
    public class DeltaServoComm
    {
        public SerialPort sp { get; set; }
        public string Name  { get; set; }

        //建立通訊埠
        public void CreateSerialPort(string portname)
        {
            try
            {
                if (sp == null)
                {
                    sp = new SerialPort();
                    sp.PortName = portname;
                    sp.BaudRate = 38400;
                    sp.Parity = Parity.None;
                    sp.DataBits = 8;
                    sp.StopBits = StopBits.Two;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //打開通訊埠
        public void OpenComport()
        {
            try 
	        {	        
		        if ((sp!=null)&&(!sp.IsOpen))
                    {
                        sp.Open();
                    }
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.Message);
	        }
            
        }

        //關閉通訊埠
        public void CloseComport()
        {
            try
            {
                if ((sp != null) && (sp.IsOpen))
                {
                    sp.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //傳送16bits資料至伺服馬達
        public void SendDataToServo16(byte SlaveAddress, UInt16 StartAddress, Int16 Data)
        {
            byte[] abuffer = new byte[6];
            byte[] buffer = new byte[8];

            abuffer[0] = SlaveAddress;
            abuffer[1] = 0x06;
            abuffer[2] = Convert.ToByte((StartAddress & 0xff00) >> 8);
            abuffer[3] = Convert.ToByte(StartAddress & 0xff);
            abuffer[4] = Convert.ToByte((Data & 0xff00) >> 8);
            abuffer[5] = Convert.ToByte(Data & 0x00ff);
            int crc = RS485MTU_CRC(abuffer);
            Array.Copy(abuffer, buffer, 6);
            buffer[6] = Convert.ToByte(crc & 0xff);
            buffer[7] = Convert.ToByte((crc & 0xff00) >> 8);
            try
            {
                if ((sp != null) && (sp.IsOpen))
                {
                    sp.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                CloseComport();
                MessageBox.Show(ex.Message);
            }
        }

        //傳送32bits資料至伺服馬達
        public void SendDataToServo32(byte SlaveAddress,UInt16 StartAddress,int Data)
        {
            byte[] abuffer = new byte[11];
            byte[] buffer = new byte[13];

            abuffer[0] = SlaveAddress;
            abuffer[1] = 0x10;
            abuffer[2] = Convert.ToByte((StartAddress & 0xff00)>>8);
            abuffer[3] = Convert.ToByte(StartAddress&0xff);
            abuffer[4] = 0x00;
            abuffer[5] = 0x02;
            abuffer[6] = 0x04;
            abuffer[7] = Convert.ToByte((Data & 0x0000ff00) >> 8);
            abuffer[8] = Convert.ToByte(Data & 0x000000ff);
            abuffer[9] = Convert.ToByte((Data & 0xff000000) >> 24);
            abuffer[10] = Convert.ToByte((Data & 0x00ff0000) >> 16);
            int crc = RS485MTU_CRC(abuffer);
            Array.Copy(abuffer, buffer, 11);
            buffer[11] = Convert.ToByte(crc & 0xff);
            buffer[12] = Convert.ToByte((crc & 0xff00)>>8);
            try
            {
                if ((sp != null) && (sp.IsOpen))
                {
                    sp.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                CloseComport();
                MessageBox.Show(ex.Message);
            }
        }

        //從伺服馬達讀取資料
        public byte[] ReadDataFromServo()
        {
            byte[] buffer = new byte[1024];
            try
            {
                if ((sp!=null)&&(sp.IsOpen))
                {
                    Array.Resize(ref buffer, sp.BytesToRead);
                    sp.Read(buffer, 0, sp.BytesToRead);
                }
            }
            catch (Exception ex)
            {
                CloseComport();
                MessageBox.Show(ex.Message);
            }
            return buffer;
        }

        //CRC偵錯
        public UInt16 RS485MTU_CRC(byte[] b)
        {
            UInt16 crc=0xffff;
            for (int i = 0; i < b.Length; i++)
            {
                crc ^= b[i];
                for (int j = 0; j < 8; j++)
                {
                    if ((crc & 0x01) == 0)
                    {
                        crc = Convert.ToUInt16(crc >> 1);
                    }
                    else
                    {
                        crc = Convert.ToUInt16((crc >> 1) ^ 0xA001);

                    }
                }
            }
            return crc;
        }
    }
}
