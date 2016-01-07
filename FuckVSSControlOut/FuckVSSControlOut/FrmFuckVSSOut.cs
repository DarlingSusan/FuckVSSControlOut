using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FuckVSSControlOut
{
    public partial class FrmFuckVSSOut : Form
    {
        public FrmFuckVSSOut()
        {
            InitializeComponent();
        }

        private void btnChooseDirect_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.Description = "";
            fd.ShowNewFolderButton = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                tbxDirectory.Text = fd.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string folder = tbxDirectory.Text;
            if (string.IsNullOrEmpty(folder.Trim()))
            {
                MessageBox.Show("尚未选择任意文件夹!\n麻蛋快去选!~");
                return;
            }
            if (MessageBox.Show("你当前选择的目录是:" + folder + ",\n是否确定清楚该目录下的VSS控制代码?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //MessageBox.Show("OK!~");
                DirectoryInfo di = new DirectoryInfo(folder);
                List<FileInfo> vssList = di.GetFiles("*.scc", SearchOption.AllDirectories).ToList<FileInfo>();
                vssList.AddRange(di.GetFiles("*.vssscc", SearchOption.AllDirectories).ToList());
                vssList.AddRange(di.GetFiles("*.vspscc", SearchOption.AllDirectories).ToList());
                foreach (FileInfo fi in vssList)
                {
                    fi.Attributes = FileAttributes.Normal;
                    fi.Delete();
                }
                FileInfo[] sln = di.GetFiles("*.sln", SearchOption.AllDirectories);
                for (int i = 0; i < sln.Length; i++)
                {
                    sln[i].Attributes = FileAttributes.Normal;
                    string file = File.ReadAllText(sln[i].FullName);
                    file = Regex.Replace(file, @"GlobalSection\(SourceCodeControl\).*?EndGlobalSection", "", RegexOptions.Singleline);
                    StreamWriter sw = new StreamWriter(sln[i].FullName, false);
                    sw.Write(file);
                    sw.Close();
                }

                FileInfo[] csproj = di.GetFiles("*.csproj", SearchOption.AllDirectories);
                for (int i = 0; i < csproj.Length; i++)
                {
                    csproj[i].Attributes = FileAttributes.Normal;
                    string file = File.ReadAllText(csproj[i].FullName);
                    file = Regex.Replace(file, @"<SccProjectName>.*?</SccProvider>", "", RegexOptions.Singleline);
                    StreamWriter sw = new StreamWriter(csproj[i].FullName, false);
                    sw.Write(file);
                    sw.Close();
                }
                MessageBox.Show("VSS控制代码已清除完毕！~");
            }
        }

        private void FrmFuckVSSOut_Activated(object sender, EventArgs e)
        {
            tbxDirectory.Focus();
        }
    }

}
