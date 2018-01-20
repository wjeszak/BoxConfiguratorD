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
            this.groupBox_connection = new System.Windows.Forms.GroupBox();
            this.button_connection = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStrip_connection = new System.Windows.Forms.ToolStripStatusLabel();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.groupBox_connection.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_connection
            // 
            this.groupBox_connection.Controls.Add(this.button_connection);
            this.groupBox_connection.Controls.Add(this.comboBox_baudrate);
            this.groupBox_connection.Controls.Add(this.comboBox_ports);
            this.groupBox_connection.Location = new System.Drawing.Point(12, 12);
            this.groupBox_connection.Name = "groupBox_connection";
            this.groupBox_connection.Size = new System.Drawing.Size(183, 81);
            this.groupBox_connection.TabIndex = 0;
            this.groupBox_connection.TabStop = false;
            this.groupBox_connection.Text = "Connection";
            // 
            // button_connection
            // 
            this.button_connection.Enabled = false;
            this.button_connection.Location = new System.Drawing.Point(97, 16);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(75, 51);
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
            this.comboBox_baudrate.Location = new System.Drawing.Point(6, 46);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(84, 21);
            this.comboBox_baudrate.TabIndex = 1;
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(6, 19);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(84, 21);
            this.comboBox_ports.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStrip_connection});
            this.statusStrip.Location = new System.Drawing.Point(0, 373);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(730, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 395);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox_connection);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "MainForm";
            this.Text = "Box Configurator";
            this.groupBox_connection.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_connection;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStrip_connection;
        private System.IO.Ports.SerialPort serial;
    }
}

