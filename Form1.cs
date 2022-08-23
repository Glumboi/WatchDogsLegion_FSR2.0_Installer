using System;
using System.Windows.Forms;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.FileMan;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.Installer;
using Glumboi.UI;
using Watch_Dogs_Legion_FSR_2._0_Installer.Core.Ini;

namespace Watch_Dogs_Legion_FSR_2._0_Installer
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string _gamePath = Properties.Settings.Default.GameLocation;

        private ConfigIni _config = new ConfigIni();

        protected override void OnHandleCreated(EventArgs e)
        {
            UIChanger.ChangeTitlebarToDark(Handle);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates the ini config file
            _config.CreateConfig();

            //Loads in the installer and game path
            InstallMod.InstallerPath = FileHandler.AssemblyDirectory;
            
            if(!string.IsNullOrEmpty(_gamePath))
            {
                Textbox_Path.Text = _gamePath;
            }
        }

        private void Textbox_Path_TextChanged(object sender, EventArgs e)
        {
            //Updates the game path
            _gamePath = Textbox_Path.Text;
            InstallMod.GamePath = Textbox_Path.Text;
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            //Opens a folder browse dialog
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
            //Checks if the gamepath is null and if not loads it in
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
