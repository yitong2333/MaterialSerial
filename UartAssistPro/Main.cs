using MaterialSkin.Controls;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace UartAssistPro
{
    public partial class Main : MaterialForm
    {
        //打开串口按钮标志位
        private bool isOpen = false;
        //接收数据缓存
        private List<byte> receiveBuffer = new List<byte>();
        //接收计数
        private int receiveCount = 0;
        //暂停标志位
        private bool isRxShow = true;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取电脑上的串口
            string[] portNames = SerialPort.GetPortNames();
            foreach (string i in portNames)
            {
                cmbPortName.Items.Add(i);
            }
            //设置默认项
            if (portNames.Length != 0)
            {
                cmbPortName.SelectedIndex = 0;
            }
            //添加端口速率
            String[] boundRate = { "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            foreach (string i in boundRate)
            {
                cmbBaudRate.Items.Add(i);
            }
            cmbBaudRate.SelectedIndex = 2;
            //设置校验位
            string[] parity = { "NONE", "ODD", "EVEN", "MARK", "SPACE" };
            foreach (string i in parity)
            {
                cmbParity.Items.Add(i);
            }
            cmbParity.SelectedIndex = 0;

            //设置数据位
            string[] dataBits = { "5", "6", "7", "8" };
            foreach (string i in dataBits)
            {
                cmbDataBit.Items.Add(i);
            }
            cmbDataBit.SelectedIndex = 3;

            //设置停止位
            string[] stopBits = { "1", "2" };
            foreach (string i in stopBits)
            {
                cmbStopBit.Items.Add(i);
            }
            cmbStopBit.SelectedIndex = 0;
            // 设置Hex为默认选中
            rbtnReceiveAscii.Checked = true;
        }
        private void txtSend_TrailingIconClick(object sender, EventArgs e)
        {
            txtSend.Clear();
        }
        private void setSerialParam(string portName, int boudRate, int databit, Parity parity, StopBits stopBits)
        {
            try
            {
                serialPort1.PortName = portName;
                serialPort1.BaudRate = boudRate;
                serialPort1.Parity = parity;
                serialPort1.DataBits = databit;
                serialPort1.StopBits = stopBits;
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口时出错：" + ex.Message);
            }
        }
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (isOpen == false)
            {
                setSerialParam(cmbPortName.Text, Convert.ToInt32(cmbBaudRate.Text),
                    Convert.ToInt32(cmbDataBit.Text), (Parity)cmbParity.SelectedIndex,
                    (StopBits)cmbStopBit.SelectedIndex + 1);
                serialPort1.Open();
                isOpen = true;
                btnOpenPort.Icon = Properties.Resources.stop;
                showToast(cmbPortName.Text + " 已打开~");
            }
            else
            {
                serialPort1.Close();
                isOpen = false;
                btnOpenPort.Icon = Properties.Resources.play;
                showToast(cmbPortName.Text + " 已关闭~");
            }
        }

        private void btnDeleteReceive_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbReceive.Text))
            {
                rtbReceive.Clear();
                receiveCount = 0;
                lblRx.Text = "0" + " Bytes";
                showToast("接收框已清空~");
            }
            else
            {
                showToast("没东西你让我清空啥");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSend != null && serialPort1.IsOpen)
            {
                serialPort1.Write(txtSend.Text);
                rtbReceive.SelectionColor = Color.Green;
                rtbReceive.AppendText("[Send] " + txtSend.Text + "\n");
                rtbReceive.SelectionColor = rtbReceive.ForeColor;
            }
            else
            {
                MessageBox.Show("串口未打开或发送框没有数据！");
            }
        }

        private void rtbReceive_TextChanged(object sender, EventArgs e)
        {
            rtbReceive.ScrollToCaret();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isRxShow)
            {
                return;
            }

            // 读取数据
            int bytesToRead = serialPort1.BytesToRead;
            if (bytesToRead <= 0)
            {
                return;
            }
            byte[] dataTemp = new byte[bytesToRead];
            serialPort1.Read(dataTemp, 0, bytesToRead);

            // 更新接收计数
            receiveCount += bytesToRead;

            // 显示接收数据
            this.Invoke((EventHandler)delegate
            {
                //tsslReceiveCount.Text = receiveCount.ToString();

                string str = "";

                if (rbtnReceiveHex.Checked)
                {
                    //str = Transform.ToHexString(dataTemp, " ");
                    str = BitConverter.ToString(dataTemp).Replace("-", " ");
                }
                else if (rbtnReceiveAscii.Checked)
                {
                    str = Encoding.GetEncoding("GB2312").GetString(dataTemp).Replace("\0", "\\0");
                }
                else if (rbtnReceiveUtf8.Checked)
                {
                    str = Encoding.GetEncoding("UTF-8").GetString(dataTemp).Replace("\0", "\\0");
                }
                lblRx.Text = receiveCount.ToString() + " Bytes";
                rtbReceive.SelectionColor = Color.Blue;
                rtbReceive.AppendText("[REC]" + str + "\n");
                rtbReceive.SelectionColor = rtbReceive.ForeColor;
            });
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isRxShow)
            {
                isRxShow = false;

            }
            else
            {
                isRxShow = true;

            }
        }
        //Toast
        private void showToast(string title)
        {
            new ToastContentBuilder()
                .SetToastDuration(ToastDuration.Short)
                .AddText(title)
                .Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 创建 SaveFileDialog 对象
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // 设置保存文件的默认文件名和默认文件类型
            saveFileDialog.FileName = "Log.txt";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // 显示 SaveFileDialog 对话框
            DialogResult result = saveFileDialog.ShowDialog();

            // 如果用户点击了 "保存" 按钮
            if (result == DialogResult.OK)
            {
                // 获取用户选择的文件名
                string fileName = saveFileDialog.FileName;

                try
                {
                    // 将 rtbReceive 中的内容保存到用户选择的文件中
                    File.WriteAllText(fileName, rtbReceive.Text);
                    MessageBox.Show("文件已成功保存！", "保存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("保存文件时出错：" + ex.Message, "保存失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSend_Enter(object sender, EventArgs e)
        {
            if (txtSend != null && serialPort1.IsOpen)
            {
                serialPort1.Write(txtSend.Text);
                rtbReceive.SelectionColor = Color.Green;
                rtbReceive.AppendText("[Send] " + txtSend.Text + "\n");
                rtbReceive.SelectionColor = rtbReceive.ForeColor;
            }
            else
            {
                MessageBox.Show("串口未打开或发送框没有数据！");
            }
        }
    }
}
