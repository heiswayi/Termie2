using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Termie
{
    public partial class SettingsWindow : Form
    {
        MainWindow mainForm = null;
        public SettingsWindow(MainWindow _mainForm)
        {
            InitializeComponent();
            this.mainForm = _mainForm;

            CommPort com = CommPort.Instance;

            int found = 0;
            string[] portList = com.GetAvailablePorts();
            for (int i=0; i<portList.Length; ++i)
            {
                string name = portList[i];
                comboboxPort.Items.Add(name);
                if (name == Settings.Port.PortName)
                    found = i;
            }
            if (portList.Length > 0)
                comboboxPort.SelectedIndex = found;

            Int32[] baudRates = {
                100,300,600,1200,2400,4800,9600,14400,19200,
                38400,56000,57600,115200,128000,256000,0
            };
            found = 0;
            for (int i=0; baudRates[i] != 0; ++i)
            {
                comboboxBaudRate.Items.Add(baudRates[i].ToString());
                if (baudRates[i] == Settings.Port.BaudRate)
                    found = i;
            }
            comboboxBaudRate.SelectedIndex = found;

            comboboxDataBits.Items.Add("5");
            comboboxDataBits.Items.Add("6");
            comboboxDataBits.Items.Add("7");
            comboboxDataBits.Items.Add("8");
            comboboxDataBits.SelectedIndex = Settings.Port.DataBits - 5;

            foreach (string s in Enum.GetNames(typeof(Parity)))
            {
                comboboxParity.Items.Add(s);
            }
            comboboxParity.SelectedIndex = (int)Settings.Port.Parity;

            foreach (string s in Enum.GetNames(typeof(StopBits)))
            {
                comboboxStopBits.Items.Add(s);
            }
            comboboxStopBits.SelectedIndex = (int)Settings.Port.StopBits;

            foreach (string s in Enum.GetNames(typeof(Handshake)))
            {
                comboboxHandshake.Items.Add(s);
            }
            comboboxHandshake.SelectedIndex = (int)Settings.Port.Handshake;

            switch (Settings.Option.AppendToSend)
            {
                case Settings.Option.AppendType.AppendNothing:
                    radioAppendNothing.Checked = true;
                    break;
                case Settings.Option.AppendType.AppendCR:
                    radioAppendCR.Checked = true;
                    break;
                case Settings.Option.AppendType.AppendLF:
                    radioAppendLF.Checked = true;
                    break;
                case Settings.Option.AppendType.AppendCRLF:
                    radioAppendCRLF.Checked = true;
                    break;
            }

            checkboxHexOutput.Checked = Settings.Option.HexOutput;
            checkboxLocalEcho.Checked = Settings.Option.LocalEcho;
            checkboxStayOnTop.Checked = Settings.Option.StayOnTop;
			checkboxFilterCaseSensitive.Checked = Settings.Option.FilterUseCase;

			textboxLogFileLocation.Text = Settings.Option.LogFileLocation;
		}

		// OK
		private void button1_Click(object sender, EventArgs e)
		{
			Settings.Port.PortName = comboboxPort.Text;
			Settings.Port.BaudRate = Int32.Parse(comboboxBaudRate.Text);
			Settings.Port.DataBits = comboboxDataBits.SelectedIndex + 5;
			Settings.Port.Parity = (Parity)comboboxParity.SelectedIndex;
			Settings.Port.StopBits = (StopBits)comboboxStopBits.SelectedIndex;
			Settings.Port.Handshake = (Handshake)comboboxHandshake.SelectedIndex;

			if (radioAppendCR.Checked)
				Settings.Option.AppendToSend = Settings.Option.AppendType.AppendCR;
			else if (radioAppendLF.Checked)
				Settings.Option.AppendToSend = Settings.Option.AppendType.AppendLF;
			else if (radioAppendCRLF.Checked)
				Settings.Option.AppendToSend = Settings.Option.AppendType.AppendCRLF;
			else
				Settings.Option.AppendToSend = Settings.Option.AppendType.AppendNothing;

			Settings.Option.HexOutput = checkboxHexOutput.Checked;
			Settings.Option.LocalEcho = checkboxLocalEcho.Checked;
			Settings.Option.StayOnTop = checkboxStayOnTop.Checked;
			Settings.Option.FilterUseCase = checkboxFilterCaseSensitive.Checked;

			Settings.Option.LogFileLocation = textboxLogFileLocation.Text;

			Settings.Write();

            this.mainForm.ShowSettingsCheck(Settings.SettingsCheck);
			Close();
		}

		// Cancel
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.ShowNewFolderButton = true;
            folderDialog.SelectedPath = Settings.Option.LogFileLocation;
            DialogResult dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Settings.Option.LogFileLocation = folderDialog.SelectedPath;
                textboxLogFileLocation.Text = folderDialog.SelectedPath;
            }
            else
            {
                textboxLogFileLocation.Text = Settings.AssemblyDirectory;
            }
        }
    }
}