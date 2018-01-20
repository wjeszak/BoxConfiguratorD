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
//                    groupBox_preview.Enabled = true;
//                    groupBox_send.Enabled = true;
//                    groupBox_statistics.Enabled = true;
                    break;

                case PortStatus.Disconnected:
                    button_connection.Text = "Connect";
                    statusStrip_connection.Text = "Disconected";
 //                   tabControl1.Enabled = false;
 //                   groupBox_preview.Enabled = false;
 //                   groupBox_send.Enabled = false;
 //                   groupBox_statistics.Enabled = false;
                    break;
                case PortStatus.Busy:
                    button_connection.Text = "Connect";
                    statusStrip_connection.Text = "Busy";
                    break;
            }
        }

        public MainForm()
        {
            InitializeComponent();
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
    }
}
