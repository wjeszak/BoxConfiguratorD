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
            this.splitContainer_write_read = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.numericUpDown_address = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_year = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_week = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_sn = new System.Windows.Forms.NumericUpDown();
            this.button_write = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_read = new System.Windows.Forms.Button();
            this.label_type = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_year = new System.Windows.Forms.Label();
            this.label_week = new System.Windows.Forms.Label();
            this.label_sn = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.checkBox_inc = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.splitContainer_main.Panel1.SuspendLayout();
            this.splitContainer_main.Panel2.SuspendLayout();
            this.splitContainer_main.SuspendLayout();
            this.splitContainer_write_read.Panel1.SuspendLayout();
            this.splitContainer_write_read.Panel2.SuspendLayout();
            this.splitContainer_write_read.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_week)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sn)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connection
            // 
            this.button_connection.Enabled = false;
            this.button_connection.Location = new System.Drawing.Point(192, 12);
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
            this.comboBox_baudrate.Location = new System.Drawing.Point(102, 12);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(84, 21);
            this.comboBox_baudrate.TabIndex = 1;
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(12, 12);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(84, 21);
            this.comboBox_ports.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_connection});
            this.statusStrip.Location = new System.Drawing.Point(0, 402);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(438, 22);
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
            // 
            // splitContainer_main
            // 
            this.splitContainer_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_main.Name = "splitContainer_main";
            this.splitContainer_main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_main.Panel1
            // 
            this.splitContainer_main.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer_main.Panel1.Controls.Add(this.button_connection);
            this.splitContainer_main.Panel1.Controls.Add(this.comboBox_ports);
            this.splitContainer_main.Panel1.Controls.Add(this.comboBox_baudrate);
            // 
            // splitContainer_main.Panel2
            // 
            this.splitContainer_main.Panel2.Controls.Add(this.textBox_log);
            this.splitContainer_main.Panel2.Controls.Add(this.splitContainer_write_read);
            this.splitContainer_main.Size = new System.Drawing.Size(438, 402);
            this.splitContainer_main.SplitterDistance = 48;
            this.splitContainer_main.TabIndex = 2;
            // 
            // splitContainer_write_read
            // 
            this.splitContainer_write_read.Enabled = false;
            this.splitContainer_write_read.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_write_read.Name = "splitContainer_write_read";
            // 
            // splitContainer_write_read.Panel1
            // 
            this.splitContainer_write_read.Panel1.BackColor = System.Drawing.Color.LightGray;
            this.splitContainer_write_read.Panel1.Controls.Add(this.checkBox_inc);
            this.splitContainer_write_read.Panel1.Controls.Add(this.button_write);
            this.splitContainer_write_read.Panel1.Controls.Add(this.numericUpDown_sn);
            this.splitContainer_write_read.Panel1.Controls.Add(this.numericUpDown_week);
            this.splitContainer_write_read.Panel1.Controls.Add(this.numericUpDown_year);
            this.splitContainer_write_read.Panel1.Controls.Add(this.numericUpDown_address);
            this.splitContainer_write_read.Panel1.Controls.Add(this.comboBox_type);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label7);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label6);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label5);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label4);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label3);
            this.splitContainer_write_read.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer_write_read.Panel2
            // 
            this.splitContainer_write_read.Panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.splitContainer_write_read.Panel2.Controls.Add(this.label_sn);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label_week);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label_year);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label_address);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label_type);
            this.splitContainer_write_read.Panel2.Controls.Add(this.button_read);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label8);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label9);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label10);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label11);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label12);
            this.splitContainer_write_read.Panel2.Controls.Add(this.label2);
            this.splitContainer_write_read.Size = new System.Drawing.Size(428, 245);
            this.splitContainer_write_read.SplitterDistance = 211;
            this.splitContainer_write_read.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Write stamp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Read stamp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of hardware";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Week";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Serial";
            // 
            // comboBox_type
            // 
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(115, 40);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(81, 21);
            this.comboBox_type.TabIndex = 7;
            // 
            // numericUpDown_address
            // 
            this.numericUpDown_address.Location = new System.Drawing.Point(116, 67);
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
            this.numericUpDown_address.Size = new System.Drawing.Size(80, 22);
            this.numericUpDown_address.TabIndex = 8;
            this.numericUpDown_address.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_year
            // 
            this.numericUpDown_year.Location = new System.Drawing.Point(116, 95);
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
            // numericUpDown_week
            // 
            this.numericUpDown_week.Location = new System.Drawing.Point(115, 123);
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
            // numericUpDown_sn
            // 
            this.numericUpDown_sn.Location = new System.Drawing.Point(116, 151);
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
            // button_write
            // 
            this.button_write.Location = new System.Drawing.Point(15, 208);
            this.button_write.Name = "button_write";
            this.button_write.Size = new System.Drawing.Size(181, 23);
            this.button_write.TabIndex = 12;
            this.button_write.Text = "Write";
            this.button_write.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Serial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Week";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Year";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Address";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Type of hardware";
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(19, 208);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(181, 23);
            this.button_read.TabIndex = 13;
            this.button_read.Text = "Read";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(133, 47);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(23, 13);
            this.label_type.TabIndex = 14;
            this.label_type.Text = "----";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(133, 76);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(23, 13);
            this.label_address.TabIndex = 15;
            this.label_address.Text = "----";
            // 
            // label_year
            // 
            this.label_year.AutoSize = true;
            this.label_year.Location = new System.Drawing.Point(133, 104);
            this.label_year.Name = "label_year";
            this.label_year.Size = new System.Drawing.Size(23, 13);
            this.label_year.TabIndex = 16;
            this.label_year.Text = "----";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Location = new System.Drawing.Point(133, 132);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(23, 13);
            this.label_week.TabIndex = 17;
            this.label_week.Text = "----";
            // 
            // label_sn
            // 
            this.label_sn.AutoSize = true;
            this.label_sn.Location = new System.Drawing.Point(133, 160);
            this.label_sn.Name = "label_sn";
            this.label_sn.Size = new System.Drawing.Size(23, 13);
            this.label_sn.TabIndex = 18;
            this.label_sn.Text = "----";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(3, 254);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(428, 78);
            this.textBox_log.TabIndex = 1;
            // 
            // checkBox_inc
            // 
            this.checkBox_inc.AutoSize = true;
            this.checkBox_inc.Location = new System.Drawing.Point(17, 185);
            this.checkBox_inc.Name = "checkBox_inc";
            this.checkBox_inc.Size = new System.Drawing.Size(77, 17);
            this.checkBox_inc.TabIndex = 13;
            this.checkBox_inc.Text = "Increment";
            this.checkBox_inc.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 424);
            this.Controls.Add(this.splitContainer_main);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Box Configurator";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer_main.Panel1.ResumeLayout(false);
            this.splitContainer_main.Panel2.ResumeLayout(false);
            this.splitContainer_main.Panel2.PerformLayout();
            this.splitContainer_main.ResumeLayout(false);
            this.splitContainer_write_read.Panel1.ResumeLayout(false);
            this.splitContainer_write_read.Panel1.PerformLayout();
            this.splitContainer_write_read.Panel2.ResumeLayout(false);
            this.splitContainer_write_read.Panel2.PerformLayout();
            this.splitContainer_write_read.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_week)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_sn)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer_write_read;
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
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.CheckBox checkBox_inc;
    }
}

