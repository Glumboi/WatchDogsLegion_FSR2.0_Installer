using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watch_Dogs_Legion_FSR_2._0_Installer.Core.Ini
{
    internal class ConfigVariables
    {
        public static string GameBinName
        {
            get { return ConfigIni.GetConfig("GameBinName", "config"); }
        }

    }
}
