using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectCSharp.GUI
{
    public partial class FormDownloadProgress : Form
    {
        public FormDownloadProgress()
        {
            InitializeComponent();
        }

        private void FormDownloadProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = false;
        }
    }
}
