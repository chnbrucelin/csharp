using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InfoSpider
{
    public partial class InfoSpiderForm : Form
    {
        public int formHeight;
        public int formWidth;

        public InfoSpiderForm()
        {
            InitializeComponent();
        }

        private void InfoSpiderForm_Load(object sender, EventArgs e)
        {
            formHeight = SystemInformation.WorkingArea.Height* 8/10;
            formWidth = SystemInformation.WorkingArea.Width*9/10;
            this.ClientSize = new System.Drawing.Size(formWidth, formHeight);

            this.SetBounds((Screen.GetBounds(this).Width / 2) - (this.Width / 2), (Screen.GetBounds(this).Height / 2) - (this.Height / 2), this.Width, this.Height, BoundsSpecified.Location);
        }
    }
}
