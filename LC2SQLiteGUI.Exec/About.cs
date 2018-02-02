using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LC2SQLiteGUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.CancelButton = btnOk;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://letztechance.org");
        }
    }
}