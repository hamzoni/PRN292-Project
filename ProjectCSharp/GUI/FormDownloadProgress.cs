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
    partial class FormDownloadProgress : Form
    {
        private FormMain gui;
        public FormDownloadProgress()
        {
            InitializeComponent();
        }
        
        public FormDownloadProgress(FormMain gui)
        {
            InitializeComponent();
            this.gui = gui;
        }

        private void FormDownloadProgress_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            e.Cancel = true;
        }

        private void FormDownloadProgress_Load(object sender, EventArgs e)
        {

        }

        private void FormDownloadProgress_Activated(object sender, EventArgs e)
        {
            int x = gui.Location.X + gui.ClientSize.Width;
            int y = gui.Location.Y;

            Location = new Point(x, y);
        }
    }
}
