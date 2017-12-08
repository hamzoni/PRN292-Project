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
    public partial class FormEditPlaylist : Form
    {
        public FormEditPlaylist()
        {
            InitializeComponent();
        }


        Point lastPoint;
        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }


        //functions move form
        private void label1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Point mousePose = 
            }
        }
    }
}
