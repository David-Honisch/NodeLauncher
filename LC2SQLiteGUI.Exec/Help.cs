using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LC2SQLiteGUI
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.CancelButton = btnOk;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}