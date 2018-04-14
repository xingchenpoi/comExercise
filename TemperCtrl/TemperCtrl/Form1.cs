using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace TemperCtrl
{

    public partial class Form1 : Form
    {
        MySerialPort mySerialPort = new MySerialPort();
        MyTemper temper = new MyTemper();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            COMComboBox.Items.Clear();//清除当前串口号中的说有串口名称
            try
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    COMComboBox.Items.Add(s);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("串口打开失败！","错误提示");
            }

            COMComboBox.SelectedIndex = 0;
        }

        //检查串口参数是否已经设置
        private bool CheckSerialPort()
        {
            if (COMComboBox.Text.Trim() == "")
                return false;
            if (BaudComboBox.Text.Trim() == "")
                return false;
            if (DataBitComboBox.Text.Trim() == "")
                return false;
            if (StopBitComboBox.Text.Trim() == "")
                return false;
            if (CheckBitBomboBox.Text.Trim() == "")
                return false;
            return true;
        }


        private void SetPortProperty() //设置串口属性
        {
            //获取串口名字
            serialPort1.PortName = COMComboBox.Text.Trim();
            //获取串口波特率
            serialPort1.BaudRate = Convert.ToInt32(BaudComboBox.Text.Trim());
            //设置数据位
            try
            {
                serialPort1.DataBits = Convert.ToInt32(DataBitComboBox.Text.Trim());
            }
            catch (Exception)
            {
                MessageBox.Show("数据位未设置正确", "错误提示");
            }
            
            //设置停止位
            float StopBit = Convert.ToSingle(StopBitComboBox.Text.Trim());
            switch (StopBit)
            {
                case 0:
                    serialPort1.StopBits = StopBits.None;
                    break;
                case 1:
                    serialPort1.StopBits = StopBits.One;
                    break;
                case (float)1.5:
                    serialPort1.StopBits = StopBits.OnePointFive;
                    break;
                case 2:
                    serialPort1.StopBits = StopBits.Two;
                    break;
            }

            //设置校验位
            string CheckBit = CheckBitBomboBox.Text.Trim();
            switch (CheckBit)
            {
                case "None":
                    serialPort1.Parity = Parity.None;
                    break;
                case "Odd":
                    serialPort1.Parity = Parity.Odd;
                    break;
                case "Even":
                    serialPort1.Parity = Parity.Even;
                    break;
                case "Mark":
                    serialPort1.Parity = Parity.Mark;
                    break;
                case "Space":
                    serialPort1.Parity = Parity.Space;
                    break;
                default:
                    break;
            }

        }

        private void Combutton_Click(object sender, EventArgs e)
        {
            if (mySerialPort.OpenState_Get() == false)
            {
                //检查串口参数是否正常
                if (!CheckSerialPort())
                {
                    MessageBox.Show("串口参数未设置正确","错误提示");
                    return;
                }
                //设置串口参数
                SetPortProperty();

                try
                {
                    //打开串口
                    serialPort1.Open();
                    //将串口状态设置为打开
                    mySerialPort.OpenState_Set(true);
                    //改变按钮显示的文字
                    Combutton.Text = "关闭串口";
                }
                catch (Exception)
                {
                    MessageBox.Show("串口打开失败", "错误提示");
                }

            }
            else
            {
                try
                {
                    //关闭串口
                    serialPort1.Close();
                    //将串口状态设置为关闭
                    mySerialPort.OpenState_Set(false);
                    //改变按钮显示的文字
                    Combutton.Text = "打开串口";
                }
                catch (Exception)
                {
                    MessageBox.Show("串口关闭失败", "错误提示");
                }
            }
        }

        private void ParaButton_Click(object sender, EventArgs e)
        {
            temper.
        }
    }

    //串口设置
    public class MySerialPort
    {
        private bool OpenFlg = false;

        public bool OpenState_Get()
        {
            return OpenFlg;
        }

        public void OpenState_Set(bool state)
        {
            OpenFlg = state;
        }

    }

    public class MyTemper
    {
        private struct Para{
            UInt16 SetTemper;       //设定温度
            UInt16 AlarmTemper;     //报警温度
            UInt16 AlarmTime;       //报警时间
            float P;
            float I;
            float D;
            UInt16 PIDCycle;        //PID计算周期
            UInt16 StartCheckTime;  //开始检测时间
        };

        private int Type { set; get; }    //温控器类型

    }
}
