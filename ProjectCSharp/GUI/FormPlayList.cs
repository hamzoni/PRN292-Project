using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using ProjectCSharp.Entities;
using System.IO;

namespace ProjectCSharp
{
     partial class FormPlayList : Form
        {

        List<Playlist> list;
        public Playlist playlist;
        public FormPlayList()
        {
            InitializeComponent();
            list = new List<Playlist>();
            test(ref list);
            loadToDataGridView();
        }


        private void test(ref List<Playlist> list)
        {
            for (int i = 0; i < 10; i++)
            {
                Playlist pl = new Playlist();
                pl.name = "A" + i;
                pl.count = i + 10;
                list.Add(pl);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }


        //move head bar
        Point lastPoint;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
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
            lastPoint = new Point(-e.X - 210, -e.Y);
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
        //done mouse move head bar


        private void btnNewPlaylist_Click(object sender, EventArgs e)
        {
            FormNewlPlayList npl = new FormNewlPlayList();
            npl.ShowDialog();
        }


        int index;
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0) return;
            if (index>=0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                string playlistName = selectedRow.Cells[1].Value.ToString();
                foreach (Playlist pl in list)
                {
                    if (pl.name == playlistName)
                    {
                        playlist = pl;
                        break;
                    }
                }
                //ko hieu sao ko truyen vao 1 playlist dc nen phai truyen vao ca class =(((
                FormDetailPlaylist dpl = new FormDetailPlaylist(playlist);
                dpl.ShowDialog();
            }
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }



        //load database to data grid view
        public void loadToDataGridView()
        {
          
            DataTable dt = new DataTable();

            dt.Columns.Add("#");
            dt.Columns.Add("Name");
            dt.Columns.Add("Count");

            for (int i = 0;i < list.Count; i++)
            {
                dt.Rows.Add(new object[] { i + 1, list[i].name, list[i].count });
            }

            dataGridView1.DataSource = dt;
        }
    }
}
