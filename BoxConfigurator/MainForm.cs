using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace BoxConfigurator
{
    public partial class MainForm : Form
    {
        enum PortStatus { Connected, Disconnected, Busy };

        private void GetPorts()
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox_ports.Items.Add(s);
            }
            if (comboBox_ports.Items.Count != 0)
            {
                button_connection.Enabled = true;
                comboBox_ports.SelectedIndex = 0;
                comboBox_baudrate.SelectedIndex = 0;
            }
        }

        private void PortStatusInfo(PortStatus status)
        {
            switch (status)
            {
                case PortStatus.Connected:
                    button_connection.Text = "Disconnect";
                    statusStrip_connection.Text = "Connected @ " + comboBox_baudrate.SelectedItem.ToString() + " bps";
                    splitContainer_write_read.Enabled = true;
                    break;

                case PortStatus.Disconnected:
                    button_connection.Text = "Connect";
                    statusStrip_connection.Text = "Disconected";
                    splitContainer_write_read.Enabled = false;
                    break;
                case PortStatus.Busy:
                    button_connection.Text = "Connect";
                    statusStrip_connection.Text = "Busy";
                    break;
            }
        }

        private void SendToPort(byte[] f, int len)
        {
            textBox_log.ForeColor = Color.Blue;
            string f_preview = null;
            for(int i = 0; i < len; i++)
            {
                f_preview += f[i].ToString("X2");
            }
            f_preview = ">" + f_preview + "\r\n";
            textBox_log.AppendText(f_preview);
            textBox_log.ScrollToCaret();
            serial.Write(f, 0, len);
            //queries++;
           // label_queries.Text = queries.ToString();
        }

        private byte CRC8(byte[] frame, byte len)
        {
            byte crc = 0x00;
            byte pos = 0;
            for (pos = 0; pos < len; pos++)
            {
                crc ^= frame[pos];
                byte i = 0;
                for (i = 8; i != 0; i--)
                {
                    if ((crc & 0x80) != 0)
                    {
                        crc <<= 1;
                        crc ^= 0x07;
                    }
                    else
                        crc <<= 1;
                }
            }
            return crc;
        }

        public MainForm()
        {
            InitializeComponent();
            checkBox_inc.Checked = true;
            GetPorts();
        }

        private void button_connection_Click(object sender, EventArgs e)
        {
            if (comboBox_ports.SelectedItem == null) return;
            if (serial.IsOpen == false)
            {
                serial.PortName = comboBox_ports.SelectedItem.ToString();
                serial.BaudRate = int.Parse(comboBox_baudrate.SelectedItem.ToString());
                try
                {
                    serial.Open();
                }
                catch (Exception ex)
                {
                    statusStrip_connection.Text = ex.Message;
                    //PortStatusInfo(PortStatus.Busy);
                }

                if (serial.IsOpen == true) PortStatusInfo(PortStatus.Connected);
            }
            else
            {
                serial.Close();
                PortStatusInfo(PortStatus.Disconnected);
            }
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            byte[] frame = new byte[10];
            frame[0] = 0xFF;
            frame[1] = 1;
            frame[2] = 5;
            SendToPort(frame, 3);
        }
    }
}
