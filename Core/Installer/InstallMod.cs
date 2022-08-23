using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.FileMan;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.Ini;

namespace Watch_Dogs_Legion_FSR_2._0_Installer.Core.Installer
{
    internal class InstallMod
    {
        public static string GamePath { get; set; }
        
        public static string InstallerPath{ get; set; }

        public static void InstallDLLs(string path)
        {
            //Gets all files in the ./bin folder and copies them to the gamepath + ./bin
            var _fsrLoc = Directory.GetFiles(InstallerPath + "./bin");

            foreach (var file in _fsrLoc)
            {
                FileHandler.CopyFile(file, path + "./" + ConfigVariables.GameBinName + "/" + Path.GetFileName(file));
            }

        }

        public static void RemoveDLLs(string path)
        {
            //Gets all files in the ./bin folder and copies them to the gamepath + ./bin
            FileHandler.DeleteFile(FileHandler.FindFirstFile(path + "./bin", "nvngx.dll"));
            FileHandler.DeleteFile(FileHandler.FindFirstFile(path + "./bin", "nvngx.ini"));
        }

        public static void ExecuteRegEdit(bool install, string path)
        {
            //Gets all files in path 
            string[] files = Directory.GetFiles(path);

            if(install)
            {
                var _installReg = FileHandler.FindFirstFile(path, "EnableSignatureOverride.reg");

                var proc = Process.Start(_installReg);
                proc.WaitForExit();

                MessageBox.Show("Install complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if (!install)
            {
                var _uninstallReg = FileHandler.FindFirstFile(path, "DisableSignatureOverride.reg");

                var proc = Process.Start(_uninstallReg);
                proc.WaitForExit();

                MessageBox.Show("Uninstall complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static void UninstallAll()
        {
            if (string.IsNullOrWhiteSpace(GamePath))
            {
                MessageBox.Show("Game path can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RemoveDLLs(GamePath);
            ExecuteRegEdit(false, InstallerPath + "./Regedits");
           
        }

        //Executes all of the above funtions in a single function
        public static void InstallAll()
        {
            if (string.IsNullOrWhiteSpace(GamePath))
            {
                MessageBox.Show("Game path can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                InstallDLLs(GamePath);
                ExecuteRegEdit(true, InstallerPath + "./Regedits");
            }
            catch (Exception e)
            {
                MessageBox.Show($"Soemthing with the install process went wrong!\n\nDetailed error: \n{e}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
