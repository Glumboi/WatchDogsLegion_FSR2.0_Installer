using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch_Dogs_Legion_FSR_2._0_Installer.Core.Ini
{
    class ConfigIni
    {
        //Get Config
        public static string GetConfig(string key, string config)
        {
            string value = "";
            string path = Application.StartupPath + "\\config.ini";
            if (File.Exists(path))
            {
                IniFile ini = new IniFile(path);
                value = ini.ReadString(config, key);
            }
            return value;
        }

        //Set Config
        public static void SetConfig(string key, string value, string config)
        {
            string path = Application.StartupPath + "\\config.ini";
            if (File.Exists(path))
            {
                IniFile ini = new IniFile(path);
                ini.WriteString(config, key, value);
            }
        }

        //Create Config
        public void CreateConfig()
        {
            string _path = Application.StartupPath + "\\config.ini";
            if (!File.Exists(_path))
            {
                IniFile ini = new IniFile(_path);

                ini.WriteString("config", "GameBinName", "\\bin");
            }
        }

        //Resets Config
        public void ResetConfig()
        {
            string _path = Application.StartupPath + "\\config.ini";
            if (File.Exists(_path))
            {
                File.Delete(_path);
            }
            CreateConfig();
        }
    }
}
