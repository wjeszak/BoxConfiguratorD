namespace BoxConfigurator
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_connection = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip_connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer_main = new System.Windows.Forms.SplitContainer();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_mod = new System.Windows.Forms.NumericUpDown();
            this.checkBox_mod = new System.Windows.Forms.CheckBox();
            this.checkBox_inc = new System.Windows.Forms.CheckBox();
            this.button_write = new System.Windows.Forms.Button();
            this.numericUpDown_sn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_week = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_year = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_address = new System.Windows.Forms.NumericUpDown();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_sn = new System.Windows.Forms.Label();
            this.label_week = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_type = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_write_stamp = new System.Windows.Forms.Panel();
            this.panel_read_stamp = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_eeprom = new System.Windows.Forms.TabPage();
            this.tabPage_flash = new System.Windows.Forms.TabPage();
            this.panel_flash = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label_hex_name = new System.Windows.Forms.Label();
            this.button_browse = new System.Windows.Forms.Button();
            this.textBox_hex_preview = new System.Windows.Forms.TextBox();
            this.button_info = new System.Windows.Forms.Button();
            this.button_write_hex = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label_time_elapsed = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_week)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_address)).BeginInit();
            this.panel_write_stamp.SuspendLayout();
            this.panel_read_stamp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage_eeprom.SuspendLayout();
            this.tabPage_flash.SuspendLayout();
            this.panel_flash.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_connection
            // 
            this.button_connection.Enabled = false;
            this.button_connection.Location = new System.Drawing.Point(129, 3);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(75, 21);
            this.button_connection.TabIndex = 2;
            this.button_connection.Text = "Connect";
            this.button_connection.UseVisualStyleBackColor = true;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "19200"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(66, 3);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(57, 21);
            this.comboBox_baudrate.TabIndex = 1;
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(3, 3);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(57, 21);
            this.comboBox_ports.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_connection});
            this.statusStrip.Location = new System.Drawing.Point(0, 461);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(466, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusStrip_connection
            // 
            this.statusStrip_connection.Name = "statusStrip_connection";
            this.statusStrip_connection.Size = new System.Drawing.Size(79, 17);
            this.statusStrip_connection.Text = "Disconnected";
            // 
            // serial
            // 
            this.serial.BaudRate = 19200;
            this.serial.PortName = "COM6";
            this.serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serial_DataReceived);
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer_main.Name = "splitContainer_main";
            this.splitContainer_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer_main.Panel1.Controls.Add(this.button_connection);
            this.splitContainer_main.Panel1.Controls.Add(this.comboBox_ports);
            this.splitContainer_main.Panel1.Controls.Add(this.comboBox_baudrate);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer_main.Panel2.Controls.Add(this.tabControl);
            this.splitContainer_main.Panel2.Controls.Add(this.panel3);
            this.splitContainer_main.Size = new System.Drawing.Size(466, 461);
            this.splitContainer_main.SplitterDistance = 27;
            this.splitContainer_main.SplitterWidth = 1;
            this.splitContainer_main.TabIndex = 2;
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Location = new System.Drawing.Point(8, 9);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_log.Size = new System.Drawing.Size(440, 101);
            this.richTextBox_log.TabIndex = 1;
            this.richTextBox_log.Text = "";
            // 
            // numericUpDown_mod
            // 
            this.numericUpDown_mod.Location = new System.Drawing.Point(169, 178);
            this.numericUpDown_mod.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_mod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_mod.Name = "numericUpDown_mod";
            this.numericUpDown_mod.Size = new System.Drawing.Size(39, 22);
            this.numericUpDown_mod.TabIndex = 15;
            this.numericUpDown_mod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox_mod
            // 
            this.checkBox_mod.AutoSize = true;
            this.checkBox_mod.Location = new System.Drawing.Point(113, 183);
            this.checkBox_mod.Name = "checkBox_mod";
            this.checkBox_mod.Size = new System.Drawing.Size(50, 17);
            this.checkBox_mod.TabIndex = 14;
            this.checkBox_mod.Text = "Mod";
            this.checkBox_mod.UseVisualStyleBackColor = true;
            // 
            // checkBox_inc
            // 
            this.checkBox_inc.AutoSize = true;
            this.checkBox_inc.Location = new System.Drawing.Point(23, 183);
            this.checkBox_inc.Name = "checkBox_inc";
            this.checkBox_inc.Size = new System.Drawing.Size(77, 17);
            this.checkBox_inc.TabIndex = 13;
            this.checkBox_inc.Text = "Increment";
            this.checkBox_inc.UseVisualStyleBackColor = true;
            // 
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(21, 206);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(181, 23);
            this.button_write.TabIndex = 12;
            this.button_write.Text = "Write";
            this.button_write.UseVisualStyleBackColor = true;
            this.button_write.Click += new System.EventHandler(this.button_write_Click);
            // 
            // numericUpDown_sn
            // 
            this.numericUpDown_sn.Location = new System.Drawing.Point(128, 149);
            this.numericUpDown_sn.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_sn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_sn.Name = "numericUpDown_sn";
            this.numericUpDown_sn.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_sn.TabIndex = 11;
            this.numericUpDown_sn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_week
            // 
            this.numericUpDown_week.Location = new System.Drawing.Point(128, 121);
            this.numericUpDown_week.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.numericUpDown_week.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_week.Name = "numericUpDown_week";
            this.numericUpDown_week.Size = new System.Drawing.Size(81, 22);
            this.numericUpDown_week.TabIndex = 10;
            this.numericUpDown_week.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_year
            // 
            this.numericUpDown_year.Location = new System.Drawing.Point(128, 93);
            this.numericUpDown_year.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numericUpDown_year.Name = "numericUpDown_year";
            this.numericUpDown_year.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_year.TabIndex = 9;
            this.numericUpDown_year.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // numericUpDown_address
            // 
            this.numericUpDown_address.Location = new System.Drawing.Point(127, 65);
            this.numericUpDown_address.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_address.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_address.Name = "numericUpDown_address";
            this.numericUpDown_address.Size = new System.Drawing.Size(81, 22);
            this.numericUpDown_address.TabIndex = 8;
            this.numericUpDown_address.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "master (0)",
            "door (1)",
            "led (2)"});
            this.comboBox_type.Location = new System.Drawing.Point(127, 38);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(81, 21);
            this.comboBox_type.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(81, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Serial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(79, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(86, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(63, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of hardware";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write stamp";
            // 
            // label_sn
            // 
            this.label_sn.AutoSize = true;
            this.label_sn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_sn.Location = new System.Drawing.Point(135, 152);
            this.label_sn.Name = "label_sn";
            this.label_sn.Size = new System.Drawing.Size(33, 19);
            this.label_sn.TabIndex = 18;
            this.label_sn.Text = "----";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_week.Location = new System.Drawing.Point(135, 124);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(33, 19);
            this.label_week.TabIndex = 17;
            this.label_week.Text = "----";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_year.Location = new System.Drawing.Point(135, 96);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(33, 19);
            this.label_year.TabIndex = 16;
            this.label_year.Text = "----";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_address.Location = new System.Drawing.Point(135, 68);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(33, 19);
            this.label_address.TabIndex = 15;
            this.label_address.Text = "----";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_type.Location = new System.Drawing.Point(135, 38);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(33, 19);
            this.label_type.TabIndex = 14;
            this.label_type.Text = "----";
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(18, 206);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(181, 23);
            this.button_read.TabIndex = 13;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(84, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(82, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Week";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(86, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(67, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(14, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "Type of hardware";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Read stamp";
            // 
            // panel_write_stamp
            // 
            this.panel_write_stamp.BackColor = System.Drawing.Color.Khaki;
            this.panel_write_stamp.Controls.Add(this.numericUpDown_mod);
            this.panel_write_stamp.Controls.Add(this.label4);
            this.panel_write_stamp.Controls.Add(this.checkBox_mod);
            this.panel_write_stamp.Controls.Add(this.label1);
            this.panel_write_stamp.Controls.Add(this.checkBox_inc);
            this.panel_write_stamp.Controls.Add(this.label3);
            this.panel_write_stamp.Controls.Add(this.button_write);
            this.panel_write_stamp.Controls.Add(this.label5);
            this.panel_write_stamp.Controls.Add(this.numericUpDown_sn);
            this.panel_write_stamp.Controls.Add(this.label6);
            this.panel_write_stamp.Controls.Add(this.numericUpDown_week);
            this.panel_write_stamp.Controls.Add(this.label7);
            this.panel_write_stamp.Controls.Add(this.numericUpDown_year);
            this.panel_write_stamp.Controls.Add(this.comboBox_type);
            this.panel_write_stamp.Controls.Add(this.numericUpDown_address);
            this.panel_write_stamp.Location = new System.Drawing.Point(3, 5);
            this.panel_write_stamp.Margin = new System.Windows.Forms.Padding(0);
            this.panel_write_stamp.Name = "panel_write_stamp";
            this.panel_write_stamp.Size = new System.Drawing.Size(220, 240);
            this.panel_write_stamp.TabIndex = 2;
            // 
            // panel_read_stamp
            // 
            this.panel_read_stamp.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel_read_stamp.Controls.Add(this.label_sn);
            this.panel_read_stamp.Controls.Add(this.label12);
            this.panel_read_stamp.Controls.Add(this.label_week);
            this.panel_read_stamp.Controls.Add(this.label2);
            this.panel_read_stamp.Controls.Add(this.label_year);
            this.panel_read_stamp.Controls.Add(this.label11);
            this.panel_read_stamp.Controls.Add(this.label_address);
            this.panel_read_stamp.Controls.Add(this.label10);
            this.panel_read_stamp.Controls.Add(this.label_type);
            this.panel_read_stamp.Controls.Add(this.label9);
            this.panel_read_stamp.Controls.Add(this.button_read);
            this.panel_read_stamp.Controls.Add(this.label8);
            this.panel_read_stamp.Location = new System.Drawing.Point(224, 5);
            this.panel_read_stamp.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panel_read_stamp.Name = "panel_read_stamp";
            this.panel_read_stamp.Size = new System.Drawing.Size(220, 240);
            this.panel_read_stamp.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Controls.Add(this.richTextBox_log);
            this.panel3.Location = new System.Drawing.Point(3, 301);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(456, 118);
            this.panel3.TabIndex = 4;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_eeprom);
            this.tabControl.Controls.Add(this.tabPage_flash);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(456, 294);
            this.tabControl.TabIndex = 5;
            // 
            // tabPage_eeprom
            // 
            this.tabPage_eeprom.Controls.Add(this.panel_write_stamp);
            this.tabPage_eeprom.Controls.Add(this.panel_read_stamp);
            this.tabPage_eeprom.Location = new System.Drawing.Point(4, 22);
            this.tabPage_eeprom.Name = "tabPage_eeprom";
            this.tabPage_eeprom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_eeprom.Size = new System.Drawing.Size(448, 268);
            this.tabPage_eeprom.TabIndex = 0;
            this.tabPage_eeprom.Text = "Write / read stamp (eeprom)";
            this.tabPage_eeprom.UseVisualStyleBackColor = true;
            // 
            // tabPage_flash
            // 
            this.tabPage_flash.Controls.Add(this.panel_flash);
            this.tabPage_flash.Location = new System.Drawing.Point(4, 22);
            this.tabPage_flash.Name = "tabPage_flash";
            this.tabPage_flash.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_flash.Size = new System.Drawing.Size(448, 268);
            this.tabPage_flash.TabIndex = 1;
            this.tabPage_flash.Text = "Write main program (flash!)";
            this.tabPage_flash.UseVisualStyleBackColor = true;
            // 
            // panel_flash
            // 
            this.panel_flash.BackColor = System.Drawing.Color.Red;
            this.panel_flash.Controls.Add(this.label_time_elapsed);
            this.panel_flash.Controls.Add(this.label14);
            this.panel_flash.Controls.Add(this.button_write_hex);
            this.panel_flash.Controls.Add(this.button_info);
            this.panel_flash.Controls.Add(this.textBox_hex_preview);
            this.panel_flash.Controls.Add(this.button_browse);
            this.panel_flash.Controls.Add(this.label_hex_name);
            this.panel_flash.Controls.Add(this.label13);
            this.panel_flash.Location = new System.Drawing.Point(4, 3);
            this.panel_flash.Margin = new System.Windows.Forms.Padding(0);
            this.panel_flash.Name = "panel_flash";
            this.panel_flash.Padding = new System.Windows.Forms.Padding(3);
            this.panel_flash.Size = new System.Drawing.Size(440, 262);
            this.panel_flash.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(41, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Hex file:";
            // 
            // label_hex_name
            // 
            this.label_hex_name.AutoSize = true;
            this.label_hex_name.Location = new System.Drawing.Point(89, 11);
            this.label_hex_name.Name = "label_hex_name";
            this.label_hex_name.Size = new System.Drawing.Size(23, 13);
            this.label_hex_name.TabIndex = 1;
            this.label_hex_name.Text = "----";
            // 
            // button_browse
            // 
            this.button_browse.Location = new System.Drawing.Point(6, 6);
            this.button_browse.Name = "button_browse";
            this.button_browse.Size = new System.Drawing.Size(29, 23);
            this.button_browse.TabIndex = 2;
            this.button_browse.Text = "...";
            this.button_browse.UseVisualStyleBackColor = true;
            this.button_browse.Click += new System.EventHandler(this.button_browse_Click);
            // 
            // textBox_hex_preview
            // 
            this.textBox_hex_preview.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_hex_preview.Location = new System.Drawing.Point(6, 35);
            this.textBox_hex_preview.Multiline = true;
            this.textBox_hex_preview.Name = "textBox_hex_preview";
            this.textBox_hex_preview.ReadOnly = true;
            this.textBox_hex_preview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_hex_preview.Size = new System.Drawing.Size(428, 171);
            this.textBox_hex_preview.TabIndex = 3;
            // 
            // button_info
            // 
            this.button_info.Location = new System.Drawing.Point(359, 212);
            this.button_info.Name = "button_info";
            this.button_info.Size = new System.Drawing.Size(75, 23);
            this.button_info.TabIndex = 4;
            this.button_info.Text = "Info";
            this.button_info.UseVisualStyleBackColor = true;
            // 
            // button_write_hex
            // 
            this.button_write_hex.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_write_hex.Location = new System.Drawing.Point(6, 212);
            this.button_write_hex.Name = "button_write_hex";
            this.button_write_hex.Size = new System.Drawing.Size(347, 23);
            this.button_write_hex.TabIndex = 5;
            this.button_write_hex.Text = "Write hex to microcontroller";
            this.button_write_hex.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 242);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Time elapsed:";
            // 
            // label_time_elapsed
            // 
            this.label_time_elapsed.AutoSize = true;
            this.label_time_elapsed.Location = new System.Drawing.Point(89, 242);
            this.label_time_elapsed.Name = "label_time_elapsed";
            this.label_time_elapsed.Size = new System.Drawing.Size(23, 13);
            this.label_time_elapsed.TabIndex = 7;
            this.label_time_elapsed.Text = "----";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 483);
            this.Controls.Add(this.splitContainer_main);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Box Configurator";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            this.splitContainer_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_mod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_week)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_address)).EndInit();
            this.panel_write_stamp.ResumeLayout(false);
            this.panel_write_stamp.PerformLayout();
            this.panel_read_stamp.ResumeLayout(false);
            this.panel_read_stamp.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage_eeprom.ResumeLayout(false);
            this.tabPage_flash.ResumeLayout(false);
            this.panel_flash.ResumeLayout(false);
            this.panel_flash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_connection;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.SplitContainer splitContainer_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_sn;
        private System.Windows.Forms.NumericUpDown numericUpDown_week;
        private System.Windows.Forms.NumericUpDown numericUpDown_year;
        private System.Windows.Forms.NumericUpDown numericUpDown_address;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_write;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_sn;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.Label label_year;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.CheckBox checkBox_inc;
        private System.Windows.Forms.RichTextBox richTextBox_log;
        private System.Windows.Forms.CheckBox checkBox_mod;
        private System.Windows.Forms.NumericUpDown numericUpDown_mod;
        private System.Windows.Forms.Panel panel_write_stamp;
        private System.Windows.Forms.Panel panel_read_stamp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_eeprom;
        private System.Windows.Forms.TabPage tabPage_flash;
        private System.Windows.Forms.Panel panel_flash;
        private System.Windows.Forms.Button button_browse;
        private System.Windows.Forms.Label label_hex_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_write_hex;
        private System.Windows.Forms.Button button_info;
        private System.Windows.Forms.TextBox textBox_hex_preview;
        private System.Windows.Forms.Label label_time_elapsed;
        private System.Windows.Forms.Label label14;
    }
}

