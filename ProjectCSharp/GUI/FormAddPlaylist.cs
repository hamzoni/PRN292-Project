using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProjectCSharp.Entities;
using TagLib;
using ProjectCSharp.DAL;
using ProjectCSharp.Controller;
using ProjectCSharp.Utility;
using System.IO;

namespace ProjectCSharp
{
    partial class FormNewlPlayList : Form
    {
        
        private Playlist playlist;
        private DataTable dt;
        private MainController ctrl;
        private FormPlayList fpl;

        public FormNewlPlayList()
        {
            InitializeComponent();
        }

        public FormNewlPlayList(MainController ctrl, FormPlayList fpl)
        {
            InitializeComponent();
            this.ctrl = ctrl;
            this.fpl = fpl;

            playlist = new Playlist();
            playlist.user = ctrl.auth.account;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Move when drag head bar
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
            lastPoint = new Point(-e.X-110, -e.Y-5);
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
   
        //check media is exist in list or not
        public bool checkDuplicated(string url)
        {
            foreach (Media item in playlist.medias)
            {
                if (item.url == url)
                    return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (dialog_openFile.ShowDialog() == DialogResult.OK)
            {
                dt = new DataTable();

                dt.Columns.Add("Name");
                dt.Columns.Add("URL");
                dt.Columns.Add("Type");

                for (int i = 0; i < dialog_openFile.FileNames.Length; i++)
                {
                    string fn = dialog_openFile.FileNames[i];
                    
                    string title = "";

                    try
                    {
                        TagLib.File tagFile = TagLib.File.Create(fn);
                        title = tagFile.Tag.Title;
                    } catch (Exception exp)
                    {

                    }
                   
                    string url = dialog_openFile.FileNames[i].ToString();

                    if (!checkDuplicated(url))
                    {
                        Media media = new Media();
                        media.name = title;

                        if (string.IsNullOrEmpty(title))
                        {
                            media.name = Path.GetFileName(fn);
                        }

                        media.url = url;
                        media.type = true;

                        playlist.medias.Add(media);
                    }
                    else
                    {
                        MessageBox.Show("This media already exist is your playlist", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                for (int i = 0; i < playlist.medias.Count; i++)
                {
                    Media m = playlist.medias[i];
                    
                    // if title is empty generated name for media
                    if (String.IsNullOrEmpty(m.name))
                    {
                        m.name = "Untitled_" + i;
                    }

                    dt.Rows.Add(new object[] { m.name, m.url, m.type });
                }

                list_medias.DataSource = dt;
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // get indices of selected medias
            List<int> indices = UIHelper.getSelectedIndices(list_medias);
            // remove all selected medias - both in list and in view
            indices.Sort();
            indices.Reverse();

            foreach (int index in indices)
            {
                list_medias.Rows.RemoveAt(index);
                playlist.medias.RemoveAt(index);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("You must enter name of playlist", "Name of playlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            playlist.name = txtPlaylistName.Text;
            
            // insert data to database
            DataModel.plMdl.insert(playlist);

            // reload data in form playlists
            fpl.loadPlaylists ();

            Close();
        }

        private void list_medias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // update media name
            string val = (string)list_medias.Rows[e.RowIndex].Cells[0].Value;
            playlist.medias[e.RowIndex].name = val;
        }
    }
}
