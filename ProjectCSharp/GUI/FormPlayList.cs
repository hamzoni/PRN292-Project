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
using ProjectCSharp.Controller;
using ProjectCSharp.DAL;
using ProjectCSharp.Utility;
using ProjectCSharp.GUI;

namespace ProjectCSharp
{
     partial class FormPlayList : Form
     {

        private List<Playlist> playlists;
        private MainController ctrl;

        public FormPlayList()
        {
            InitializeComponent();
        }

        public FormPlayList(MainController ctrl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
            setup();
        }

        private void setup()
        {
            loadPlaylists();
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
            FormNewlPlayList npl = new FormNewlPlayList(ctrl, this);
            npl.ShowDialog();
        }

        public void loadPlaylists()
        {
            playlists = DataModel.plMdl.searchByAccount(ctrl.auth.account.id);
            loadToDataGridView();
        }

        int index;
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            int index = UIHelper.getSelectedIndices(list_playlists)[0];

            new FormDetailPlaylist(playlists[index]).Show();
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

            for (int i = 0; i < playlists.Count; i++)
            {
                dt.Rows.Add(new object[] { i + 1, playlists[i].name, playlists[i].count });
            }

            list_playlists.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> indices = UIHelper.getSelectedIndices(list_playlists);
            indices.Sort();
            indices.Reverse();
            
            foreach (int index in indices)
            {
                // delete in views
                list_playlists.Rows.RemoveAt(index);

                // delete in database
                DataModel.plMdl.delete(playlists[index].id);

                // delete in memory
                playlists.RemoveAt(index);
            }
        }

        private void btn_choosePlaylist_Click(object sender, EventArgs e)
        {
            int index = UIHelper.getSelectedIndices(list_playlists)[0];
            Playlist playlist = playlists[index];

            ctrl.loadPlaylist(playlist);

            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int index = UIHelper.getSelectedIndices(list_playlists)[0];
            Playlist playlist = playlists[index];

            new FormEditPlaylist(playlist, this).Show();
        }
    }
}
