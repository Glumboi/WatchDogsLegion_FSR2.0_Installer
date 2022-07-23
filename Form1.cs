using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.FileMan;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.Installer;

namespace Watch_Dogs_Legion_FSR_2._0_Installer
{
    public partial class Form1 : Form
    {
        string _gamePath = Properties.Settings.Default.GameLocation;

        [DllImport("DwmApi")] //System.Runtime.InteropServices
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstallMod.InstallerPath = FileHandler.AssemblyDirectory;

            if(!string.IsNullOrEmpty(_gamePath))
            {
                Textbox_Path.Text = _gamePath;
            }
        }

        private void Textbox_Path_TextChanged(object sender, EventArgs e)
        {
            _gamePath = Textbox_Path.Text;
            InstallMod.GamePath = Textbox_Path.Text;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Textbox_Path.Text = FileHandler.OpenFolder();
            InstallMod.GamePath = Textbox_Path.Text;
        }

        private void Button_Install_Click(object sender, EventArgs e)
        {
            InstallMod.InstallAll();
        }

        private void Button_Uninstall_Click(object sender, EventArgs e)
        {
            InstallMod.UninstallAll();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(string.IsNullOrEmpty(_gamePath))
            {
                Properties.Settings.Default.GameLocation = "Enter your WDL path here...";
                Properties.Settings.Default.Save();
                return;
            }
            Properties.Settings.Default.GameLocation = _gamePath;
            Properties.Settings.Default.Save();
        }
    }
}
