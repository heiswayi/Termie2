namespace Termie
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboboxHandshake = new System.Windows.Forms.ComboBox();
            this.comboboxStopBits = new System.Windows.Forms.ComboBox();
            this.comboboxParity = new System.Windows.Forms.ComboBox();
            this.comboboxDataBits = new System.Windows.Forms.ComboBox();
            this.comboboxBaudRate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkboxHexOutput = new System.Windows.Forms.CheckBox();
            this.checkboxFilterCaseSensitive = new System.Windows.Forms.CheckBox();
            this.checkboxStayOnTop = new System.Windows.Forms.CheckBox();
            this.checkboxLocalEcho = new System.Windows.Forms.CheckBox();
            this.radioAppendCRLF = new System.Windows.Forms.RadioButton();
            this.radioAppendLF = new System.Windows.Forms.RadioButton();
            this.radioAppendCR = new System.Windows.Forms.RadioButton();
            this.radioAppendNothing = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textboxLogFileLocation = new System.Windows.Forms.TextBox();
            this.buttonChangeLFL = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboboxHandshake);
            this.groupBox1.Controls.Add(this.comboboxStopBits);
            this.groupBox1.Controls.Add(this.comboboxParity);
            this.groupBox1.Controls.Add(this.comboboxDataBits);
            this.groupBox1.Controls.Add(this.comboboxBaudRate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboboxPort);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port configurations";
            // 
            // comboboxHandshake
            // 
            this.comboboxHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxHandshake.FormattingEnabled = true;
            this.comboboxHandshake.Location = new System.Drawing.Point(9, 158);
            this.comboboxHandshake.Name = "comboboxHandshake";
            this.comboboxHandshake.Size = new System.Drawing.Size(136, 21);
            this.comboboxHandshake.TabIndex = 11;
            // 
            // comboboxStopBits
            // 
            this.comboboxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxStopBits.FormattingEnabled = true;
            this.comboboxStopBits.Location = new System.Drawing.Point(68, 116);
            this.comboboxStopBits.Name = "comboboxStopBits";
            this.comboboxStopBits.Size = new System.Drawing.Size(77, 21);
            this.comboboxStopBits.TabIndex = 10;
            // 
            // comboboxParity
            // 
            this.comboboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxParity.FormattingEnabled = true;
            this.comboboxParity.Location = new System.Drawing.Point(68, 92);
            this.comboboxParity.Name = "comboboxParity";
            this.comboboxParity.Size = new System.Drawing.Size(77, 21);
            this.comboboxParity.TabIndex = 9;
            // 
            // comboboxDataBits
            // 
            this.comboboxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDataBits.FormattingEnabled = true;
            this.comboboxDataBits.Location = new System.Drawing.Point(68, 68);
            this.comboboxDataBits.Name = "comboboxDataBits";
            this.comboboxDataBits.Size = new System.Drawing.Size(77, 21);
            this.comboboxDataBits.TabIndex = 8;
            // 
            // comboboxBaudRate
            // 
            this.comboboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxBaudRate.FormattingEnabled = true;
            this.comboboxBaudRate.Location = new System.Drawing.Point(68, 44);
            this.comboboxBaudRate.Name = "comboboxBaudRate";
            this.comboboxBaudRate.Size = new System.Drawing.Size(77, 21);
            this.comboboxBaudRate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Hardware Handshaking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Stop bits";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port";
            // 
            // comboboxPort
            // 
            this.comboboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxPort.FormattingEnabled = true;
            this.comboboxPort.Location = new System.Drawing.Point(68, 20);
            this.comboboxPort.Name = "comboboxPort";
            this.comboboxPort.Size = new System.Drawing.Size(77, 21);
            this.comboboxPort.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkboxHexOutput);
            this.groupBox2.Controls.Add(this.checkboxFilterCaseSensitive);
            this.groupBox2.Controls.Add(this.checkboxStayOnTop);
            this.groupBox2.Controls.Add(this.checkboxLocalEcho);
            this.groupBox2.Controls.Add(this.radioAppendCRLF);
            this.groupBox2.Controls.Add(this.radioAppendLF);
            this.groupBox2.Controls.Add(this.radioAppendCR);
            this.groupBox2.Controls.Add(this.radioAppendNothing);
            this.groupBox2.Location = new System.Drawing.Point(201, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(182, 193);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // checkboxHexOutput
            // 
            this.checkboxHexOutput.AutoSize = true;
            this.checkboxHexOutput.Location = new System.Drawing.Point(15, 102);
            this.checkboxHexOutput.Name = "checkboxHexOutput";
            this.checkboxHexOutput.Size = new System.Drawing.Size(86, 17);
            this.checkboxHexOutput.TabIndex = 8;
            this.checkboxHexOutput.Text = "Hex output";
            this.checkboxHexOutput.UseVisualStyleBackColor = true;
            // 
            // checkboxFilterCaseSensitive
            // 
            this.checkboxFilterCaseSensitive.AutoSize = true;
            this.checkboxFilterCaseSensitive.Location = new System.Drawing.Point(15, 159);
            this.checkboxFilterCaseSensitive.Name = "checkboxFilterCaseSensitive";
            this.checkboxFilterCaseSensitive.Size = new System.Drawing.Size(152, 17);
            this.checkboxFilterCaseSensitive.TabIndex = 7;
            this.checkboxFilterCaseSensitive.Text = "Filter case sensitive";
            this.checkboxFilterCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // checkboxStayOnTop
            // 
            this.checkboxStayOnTop.AutoSize = true;
            this.checkboxStayOnTop.Location = new System.Drawing.Point(15, 140);
            this.checkboxStayOnTop.Name = "checkboxStayOnTop";
            this.checkboxStayOnTop.Size = new System.Drawing.Size(92, 17);
            this.checkboxStayOnTop.TabIndex = 6;
            this.checkboxStayOnTop.Text = "Stay on top";
            this.checkboxStayOnTop.UseVisualStyleBackColor = true;
            // 
            // checkboxLocalEcho
            // 
            this.checkboxLocalEcho.AutoSize = true;
            this.checkboxLocalEcho.Location = new System.Drawing.Point(15, 121);
            this.checkboxLocalEcho.Name = "checkboxLocalEcho";
            this.checkboxLocalEcho.Size = new System.Drawing.Size(86, 17);
            this.checkboxLocalEcho.TabIndex = 5;
            this.checkboxLocalEcho.Text = "Local echo";
            this.checkboxLocalEcho.UseVisualStyleBackColor = true;
            // 
            // radioAppendCRLF
            // 
            this.radioAppendCRLF.AutoSize = true;
            this.radioAppendCRLF.Location = new System.Drawing.Point(15, 73);
            this.radioAppendCRLF.Name = "radioAppendCRLF";
            this.radioAppendCRLF.Size = new System.Drawing.Size(97, 17);
            this.radioAppendCRLF.TabIndex = 3;
            this.radioAppendCRLF.TabStop = true;
            this.radioAppendCRLF.Text = "Append CR-LF";
            this.radioAppendCRLF.UseVisualStyleBackColor = true;
            // 
            // radioAppendLF
            // 
            this.radioAppendLF.AutoSize = true;
            this.radioAppendLF.Location = new System.Drawing.Point(15, 55);
            this.radioAppendLF.Name = "radioAppendLF";
            this.radioAppendLF.Size = new System.Drawing.Size(79, 17);
            this.radioAppendLF.TabIndex = 2;
            this.radioAppendLF.TabStop = true;
            this.radioAppendLF.Text = "Append LF";
            this.radioAppendLF.UseVisualStyleBackColor = true;
            // 
            // radioAppendCR
            // 
            this.radioAppendCR.AutoSize = true;
            this.radioAppendCR.Location = new System.Drawing.Point(15, 37);
            this.radioAppendCR.Name = "radioAppendCR";
            this.radioAppendCR.Size = new System.Drawing.Size(79, 17);
            this.radioAppendCR.TabIndex = 1;
            this.radioAppendCR.TabStop = true;
            this.radioAppendCR.Text = "Append CR";
            this.radioAppendCR.UseVisualStyleBackColor = true;
            // 
            // radioAppendNothing
            // 
            this.radioAppendNothing.AutoSize = true;
            this.radioAppendNothing.Location = new System.Drawing.Point(15, 19);
            this.radioAppendNothing.Name = "radioAppendNothing";
            this.radioAppendNothing.Size = new System.Drawing.Size(109, 17);
            this.radioAppendNothing.TabIndex = 0;
            this.radioAppendNothing.TabStop = true;
            this.radioAppendNothing.Text = "Append nothing";
            this.radioAppendNothing.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(400, 25);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(400, 62);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // textboxLogFileLocation
            // 
            this.textboxLogFileLocation.Location = new System.Drawing.Point(8, 19);
            this.textboxLogFileLocation.Name = "textboxLogFileLocation";
            this.textboxLogFileLocation.ReadOnly = true;
            this.textboxLogFileLocation.Size = new System.Drawing.Size(263, 20);
            this.textboxLogFileLocation.TabIndex = 5;
            // 
            // buttonChangeLFL
            // 
            this.buttonChangeLFL.Location = new System.Drawing.Point(280, 17);
            this.buttonChangeLFL.Name = "buttonChangeLFL";
            this.buttonChangeLFL.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeLFL.TabIndex = 6;
            this.buttonChangeLFL.Text = "Change";
            this.buttonChangeLFL.UseVisualStyleBackColor = true;
            this.buttonChangeLFL.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textboxLogFileLocation);
            this.groupBox3.Controls.Add(this.buttonChangeLFL);
            this.groupBox3.Location = new System.Drawing.Point(14, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Log File Location";
            // 
            // SerialPortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 270);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SerialPortSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serial Port Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboboxPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxParity;
        private System.Windows.Forms.ComboBox comboboxDataBits;
        private System.Windows.Forms.ComboBox comboboxBaudRate;
        private System.Windows.Forms.ComboBox comboboxStopBits;
        private System.Windows.Forms.CheckBox checkboxFilterCaseSensitive;
        private System.Windows.Forms.CheckBox checkboxStayOnTop;
        private System.Windows.Forms.CheckBox checkboxLocalEcho;
        private System.Windows.Forms.RadioButton radioAppendCRLF;
        private System.Windows.Forms.RadioButton radioAppendLF;
        private System.Windows.Forms.RadioButton radioAppendCR;
        private System.Windows.Forms.RadioButton radioAppendNothing;
        private System.Windows.Forms.ComboBox comboboxHandshake;
		private System.Windows.Forms.CheckBox checkboxHexOutput;
		private System.Windows.Forms.TextBox textboxLogFileLocation;
		private System.Windows.Forms.Button buttonChangeLFL;
		private System.Windows.Forms.GroupBox groupBox3;
    }
}