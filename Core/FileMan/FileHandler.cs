using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watch_Dogs_Legion_FSR_2._0_Installer.Core.FileMan
{
    internal class FileHandler
    {
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

        public static string FindFirstFile(string dir, string file)
        {
            if (System.IO.File.Exists(Path.Combine(dir, file)))
            {
                return Path.Combine(dir, file);
            }
            foreach (var subDir in System.IO.Directory.EnumerateDirectories(dir))
            {
                var result = FindFirstFile(subDir, file);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        public static void CopyFile(string sourceFile, string destinationFile)
        {
            System.IO.File.Copy(sourceFile, destinationFile, true);
        }

        public static void DeleteFile(string file)
        {
            System.IO.File.Delete(file);
        }

        public static void MoveFile(string sourceFile, string destinationFile)
        {
            System.IO.File.Move(sourceFile, destinationFile);
        }

        public static void CreateDirectory(string directory)
        {
            System.IO.Directory.CreateDirectory(directory);
        }

        public static void DeleteDirectory(string directory)
        {
            System.IO.Directory.Delete(directory, true);
        }
        
        public static string OpenFolder()
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return dialog.FileName;
            }

            return null;
        }
    }
}
