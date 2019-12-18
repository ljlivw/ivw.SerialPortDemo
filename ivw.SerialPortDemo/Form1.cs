using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ivw.SerialPortDemo
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var vs = SerialPort.GetPortNames();
            cbbPortName.Items.AddRange(vs);
            if (vs.Length > 0)
            {
                cbbPortName.SelectedIndex = 0;
            }

            this.btnOpen.Click += BtnOpen_Click;
            this.btnWrite.Click += BtnWrite_Click;

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void BtnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWrite.Text))
            {
                MessageBox.Show("无法发送空数据");
                return;
            }

            SerialWeite(txtWrite.Text);
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.btnOpen.Text == "打开")
                {
                    SerialCheck();
                }
                else
                {
                    serialPort.Close();
                    this.rtbInfo.Text += "关闭串口成功" + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            await Task.Delay(1000);
            string sRet = string.Empty;
            byte[] bRet = new byte[1024];
            int iRet = serialPort.Read(bRet, 0, bRet.Length);
            if (iRet <= 0)
            {
                return;
            }
            //serialPort.DiscardInBuffer();
            sRet = Encoding.UTF8.GetString(bRet);
            rtbInfo.BeginInvoke(new MethodInvoker(() => { rtbInfo.Text += $"数据返回：{sRet}{Environment.NewLine}"; }));
        }

        void SerialCheck()
        {
            if (string.IsNullOrEmpty(cbbPortName.Text) || string.IsNullOrEmpty(txtBaudRate.Text))
            {
                MessageBox.Show("请输入串口号和波特率");
                return;
            }
            serialPort.PortName = cbbPortName.Text;
            serialPort.BaudRate = int.Parse(txtBaudRate.Text);
            if (!string.IsNullOrEmpty(txtDataBits.Text) && txtDataBits.Text != "0")
            {
                serialPort.DataBits = int.Parse(txtDataBits.Text);
            }
            if (cbStopBits.Checked)
            {
                serialPort.StopBits = StopBits.One;
            }
            else
            {
                serialPort.StopBits = StopBits.None;
            }
            if (cbParity.Checked)
            {
                serialPort.Parity = Parity.Odd;
            }
            else
            {
                serialPort.Parity = Parity.None;
            }

            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                this.btnOpen.Text = "关闭";
                rtbInfo.Text += $"返回消息：串口打开成功{Environment.NewLine}";
            }
        }

        void SerialWeite(string data)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口没打开，无法发送数据");
                return;
            }

            byte[] vs = Encoding.UTF8.GetBytes(data);
            serialPort.Write(vs, 0, vs.Length);
            rtbInfo.Text += $"发送数据：{data}{Environment.NewLine}";
        }
    }
}
