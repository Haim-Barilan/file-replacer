using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_replacer
{
    public partial class Form1 : MaterialForm
    {
        public static ListBoxLog listBoxLog;

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            listBoxLog = new ListBoxLog(loggerListBox);
            this.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.destTextField.Text = ConfigurationSettings.AppSettings.Get("defaultLocation");
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string sourceFile = this.sourceTextField.Text;
            if (!File.Exists(sourceFile))
            {
                listBoxLog.Log(Level.Error, $"File {sourceFile} not exists");
                return;
            }
            string directoryToTraverse = this.destTextField.Text;
            if (!Directory.Exists(directoryToTraverse))
            {
                listBoxLog.Log(Level.Error, $"Directory {directoryToTraverse} not exists");
                return;
            }
            List<string> filesToReplace = GetFiles(directoryToTraverse, Path.GetFileName(sourceFile), this.recursiveCheckBox.Enabled);
            string timeStamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            listBoxLog.Log(Level.Info, $"Process started{(this.recursiveCheckBox.Enabled ? " recursively" : "")}");
            listBoxLog.Log(Level.Info, $"Backup is {(this.backupCheckBox.Enabled ? $"Enabled. Original files will be saved with timestamp {timeStamp}" : "Disabled. Original files will not be saved")}");
            foreach (string targetFile in filesToReplace)
            {
                try
                {
                    if (this.backupCheckBox.Enabled)
                    {
                        File.Copy(targetFile, targetFile + timeStamp, true);
                    }
                    File.Copy(sourceFile, targetFile, true);
                    listBoxLog.Log(Level.Info, $"{targetFile} replaced");
                }
                catch (Exception ex)
                {
                    listBoxLog.Log(Level.Error, $"Faild to copy {targetFile}");
                    listBoxLog.Log(Level.Error, $"{ex.Message}");
                    listBoxLog.Log(Level.Error, $"{ex.StackTrace}");
                }
            }

        }

        static List<string> GetFiles(string directoryPath, string fileName, bool isRecursive)
        {
            var fileList = new List<string>();
            if (isRecursive)
            {
                foreach (var subDir in Directory.GetDirectories(directoryPath))
                {
                    fileList.AddRange(GetFiles(subDir, fileName, isRecursive));
                }
            }
            fileList.AddRange(Directory.GetFiles(directoryPath, fileName));
            return fileList;
        }

    }
}
