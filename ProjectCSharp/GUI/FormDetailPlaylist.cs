using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using ProjectCSharp.Entities;

namespace ProjectCSharp
{
    partial class FormDetailPlaylist : Form
    {
        
        SqlConnection con;
        string connection = ConfigurationManager.ConnectionStrings["DBI"].ToString();

        Playlist playlist;
        

        public FormDetailPlaylist()
        {
            InitializeComponent();
        }

        public FormDetailPlaylist(Playlist xPlaylist)
        {
            InitializeComponent();
            this.playlist = xPlaylist;
            lblNameOfPlaylist.Text = playlist.name;
            loadToDataGridView();
            
        }



        // move head bar
        Point lastPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            
            loadToDataGridView();

            lastPoint = new Point(-e.X, -e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(lastPoint.X, lastPoint.Y);
                Location = mousePose;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(-e.X-100, -e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(lastPoint.X, lastPoint.Y);
                Location = mousePose;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void loadToDataGridView()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("URL");
            dt.Columns.Add("Type");
            if (playlist.medias != null)
            {
                foreach (Media media in playlist.medias)
                {
                    dt.Rows.Add(new object[] { media.id, media.name, media.url, media.type });
                }
            }

            dataGridView1.DataSource = dt;
        }
    }
}
