using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InfoSpider
{
    public partial class InfoSpiderForm : Form
    {
        public InfoSpiderForm()
        {
            InitializeComponent();
        }

        private void InfoSpiderForm_Load(object sender, EventArgs e)
        {
            //根据屏幕设置窗体大小
            this.ClientSize = new System.Drawing.Size(SystemInformation.WorkingArea.Width*9/10, SystemInformation.WorkingArea.Height* 8/10);

            //居中
            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2), (Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, BoundsSpecified.Location);
        }

        private void WriteToFile(string FileName, string WriteString)
        {
            FileStream fsMyfile = new FileStream(FileName, FileMode.Append, FileAccess.Write);
            StreamWriter swMyfile = new StreamWriter(fsMyfile);

            swMyfile.WriteLine(WriteString);
            swMyfile.Flush();

            fsMyfile.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (browser.IsBusy == true || browser.Url!=null && browser.Document == null)
            {
                return;
            }
        }
    }
}
