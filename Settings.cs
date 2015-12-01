using System;
using System.IO;
using System.IO.Ports;
using System.Collections;
using System.Windows.Forms;
using System.Reflection; // for Application.StartupPath

namespace Termie
{
    /// <summary>
    /// Persistent settings
    /// </summary>
    public class Settings
    {
        /// <summary> Port settings. </summary>
        public class Port
        {
            public static string PortName = "COM1";
            public static int BaudRate = 9600;
            public static int DataBits = 8;
            public static System.IO.Ports.Parity Parity = System.IO.Ports.Parity.None;
            public static System.IO.Ports.StopBits StopBits = System.IO.Ports.StopBits.One;
            public static System.IO.Ports.Handshake Handshake = System.IO.Ports.Handshake.None;
        }

        /// <summary> Option settings. </summary>
        public class Option
        {
            public enum AppendType
            {
                AppendNothing,
                AppendCR,
                AppendLF,
                AppendCRLF
            }

            public static AppendType AppendToSend = AppendType.AppendCR;
            public static bool HexOutput = false;
            public static bool MonoFont = true;
            public static bool LocalEcho = true;
            public static bool StayOnTop = false;
			public static bool FilterUseCase = false;
			public static string LogFileLocation = AssemblyDirectory;
		}

        /// <summary>
        ///   Read the settings from disk. </summary>
        public static void Read()
        {
            INIFile ini = new INIFile(Application.StartupPath + "\\Termie2.ini");
            Port.PortName = ini.ReadValue("Port", "PortName", Port.PortName);
            Port.BaudRate = ini.ReadValue("Port", "BaudRate", Port.BaudRate);
            Port.DataBits = ini.ReadValue("Port", "DataBits", Port.DataBits);
            Port.Parity = (Parity)Enum.Parse(typeof(Parity), ini.ReadValue("Port", "Parity", Port.Parity.ToString()));
            Port.StopBits = (StopBits)Enum.Parse(typeof(StopBits), ini.ReadValue("Port", "StopBits", Port.StopBits.ToString()));
            Port.Handshake = (Handshake)Enum.Parse(typeof(Handshake), ini.ReadValue("Port", "Handshake", Port.Handshake.ToString()));

            Option.AppendToSend = (Option.AppendType)Enum.Parse(typeof(Option.AppendType), ini.ReadValue("Option", "AppendToSend", Option.AppendToSend.ToString()));
            Option.HexOutput = bool.Parse(ini.ReadValue("Option", "HexOutput", Option.HexOutput.ToString()));
            Option.LocalEcho = bool.Parse(ini.ReadValue("Option", "LocalEcho", Option.LocalEcho.ToString()));
			Option.StayOnTop = bool.Parse(ini.ReadValue("Option", "StayOnTop", Option.StayOnTop.ToString()));
			Option.FilterUseCase = bool.Parse(ini.ReadValue("Option", "FilterUseCase", Option.FilterUseCase.ToString()));
		}

        /// <summary>
        ///   Write the settings to disk. </summary>
        public static void Write()
        {
            INIFile ini = new INIFile(Application.StartupPath + "\\Termie2.ini");
            ini.WriteValue("Port", "PortName", Port.PortName);
            ini.WriteValue("Port", "BaudRate", Port.BaudRate);
            ini.WriteValue("Port", "DataBits", Port.DataBits);
            ini.WriteValue("Port", "Parity", Port.Parity.ToString());
            ini.WriteValue("Port", "StopBits", Port.StopBits.ToString());
            ini.WriteValue("Port", "Handshake", Port.Handshake.ToString());

            ini.WriteValue("Option", "AppendToSend", Option.AppendToSend.ToString());
            ini.WriteValue("Option", "HexOutput", Option.HexOutput.ToString());
            ini.WriteValue("Option", "LocalEcho", Option.LocalEcho.ToString());
			ini.WriteValue("Option", "StayOnTop", Option.StayOnTop.ToString());
			ini.WriteValue("Option", "FilterUseCase", Option.FilterUseCase.ToString());
		}

        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly.GetExecutingAssembly().CodeBase;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path);
            }
        }

        public static string SettingsCheck
        {
            get
            {
                string p = Port.Parity.ToString().Substring(0, 1);   //First char
                string h = Port.Handshake.ToString();
                if (Port.Handshake == Handshake.None)
                    h = "no handshake"; // more descriptive than "None"
                return String.Format("{0}: {1} bps, {2}{3}{4}, {5}",
                        Port.PortName, Port.BaudRate,
                        Port.DataBits, p, (int)Port.StopBits, h);
            }
        }
	}
}
