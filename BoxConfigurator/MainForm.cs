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
        enum Frame { Command, TypeOfHardware, Address, Year, Week, SnHi, SnLo, Crc, End };
        // C++ style "function pointer"
        delegate void SetTextCallback(byte[] f);
        int desired_data = 9;
        int received_data = 0;
        int position = 0;
        byte[] rxbytearray = new byte[9];

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
            richTextBox_log.SelectionColor = Color.Blue;
            string f_preview = null;
            for(int i = 0; i < len; i++)
            {
                f_preview += "[" + f[i].ToString() + "]";
            }
            f_preview = ">" + f_preview + "\r\n";
            richTextBox_log.AppendText(f_preview);
            richTextBox_log.ScrollToCaret();
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
            comboBox_type.SelectedIndex = 1;
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
            byte[] frame = new byte[9];
            frame[(int)Frame.Command] = 1;
            frame[(int)Frame.TypeOfHardware] = 0;
            frame[(int)Frame.Address] = 0;
            frame[(int)Frame.Year] = 0;
            frame[(int)Frame.Week] = 0;
            frame[(int)Frame.SnHi] = 0;
            frame[(int)Frame.SnLo] = 0;
            frame[(int)Frame.Crc] = CRC8(frame, 7);
            frame[(int)Frame.End] = 10;
            SendToPort(frame, 9);
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int numbytes = serial.BytesToRead;

            received_data += numbytes;
            if (received_data <= desired_data)
            {
                for (int i = position; i < received_data; i++)
                {
                    rxbytearray[i] = (byte)serial.ReadByte();
                }
                position += numbytes;
            }

            if (received_data == desired_data)
            {
                received_data = 0;
                position = 0;
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { rxbytearray });
            }
        }

        private void SetText(byte[] f)
        {
            richTextBox_log.SelectionColor = Color.Green;
            string f_preview = null;
            for (int i = 0; i < 9; i++)
            {
                f_preview += "[" + f[i].ToString() + "]";
            }
            f_preview = "<" + f_preview + "\r\n";
            richTextBox_log.AppendText(f_preview);
            richTextBox_log.ScrollToCaret();
            FillFields(f);
        }

        private void FillFields(byte[] data)
        {
            byte type = data[(int)Frame.TypeOfHardware];
            string str_type = null;
            switch (type)
            {
                case 0:
                    str_type = "master (0)";
                    break;
                case 1:
                    str_type = "door (1)";
                    break;
                case 2:
                    str_type = "led (2)";
                    break;
                default:
                    str_type = "no stamp!";
                    break;
            }
            label_type.Text = str_type;
            label_address.Text = data[(int)Frame.Address].ToString();
            label_year.Text = data[(int)Frame.Year].ToString();
            label_week.Text = data[(int)Frame.Week].ToString();
            int sn = (data[(int)Frame.SnHi] << 8) | (data[(int)Frame.SnLo] & 0xFF);
            label_sn.Text = sn.ToString();
        }

        private void button_write_Click(object sender, EventArgs e)
        {
            byte[] frame = new byte[9];
            frame[(int)Frame.Command] = 2;
            frame[(int)Frame.TypeOfHardware] = (byte)comboBox_type.SelectedIndex;
            frame[(int)Frame.Address] = (byte)numericUpDown_address.Value;
            frame[(int)Frame.Year] = (byte)numericUpDown_year.Value;
            frame[(int)Frame.Week] = (byte)numericUpDown_week.Value;
            frame[(int)Frame.SnHi] = (byte)((int)numericUpDown_sn.Value >> 8);
            frame[(int)Frame.SnLo] = (byte)((int)numericUpDown_sn.Value & 0xFF);
            frame[(int)Frame.Crc] = CRC8(frame, 7);
            frame[(int)Frame.End] = 10;
            SendToPort(frame, 9);
            if (checkBox_inc.Checked == true)
            {
                numericUpDown_address.Value++;
                numericUpDown_sn.Value++;
            }
            if (checkBox_mod.Checked == true && numericUpDown_address.Value % (numericUpDown_mod.Value + 1) == 0)
                numericUpDown_address.Value = 1;
        }
    }
}
