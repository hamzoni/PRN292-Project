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


namespace ProjectCSharp
{
    public partial class FormNewlPlayList : Form
    {
        
        Playlist playlist;
        PlaylistMedia playlistMedia;
        List<Media> list;
        DataTable dt;
        public FormNewlPlayList()
        {
            InitializeComponent();
            list = new List<Media>();
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
        //done move head bar 




        //check media is exist in list or not
        public bool checkExistMedia(string title, string url)
        {
            int check = 0;
            foreach (Media item in list)
            {
                if (item.name == title &&  item.url == url)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 0) return false;
            return true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("URL");
                dt.Columns.Add("Type of File");



                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    TagLib.File tagFile = TagLib.File.Create(openFileDialog1.FileNames[i]);
                    string title = tagFile.Tag.Title;
                    string url = openFileDialog1.FileNames[i].ToString();

                    if (checkExistMedia(title, url) == false)
                    {
                        Media media = new Media();
                        media.name = title;
                        media.url = url;
                        media.type = true; //tam thoi the da
                        list.Add(media);

                    }
                    else
                    {
                        MessageBox.Show("This media already exist is your playlist", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                for (int i = 0; i < list.Count; i++)
                {
                    dt.Rows.Add(new object[] { list[i].name, list[i].url, list[i].type });
                }

                dataGridView1.DataSource = dt;
            }
           
            
        }


        int index;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (list.Count == 0 || index == list.Count) return;
            if (index >= 0)
            {
                string title = dataGridView1.Rows[index].Cells[0].Value.ToString();
                string url = dataGridView1.Rows[index].Cells[1].Value.ToString();
                if(checkExistMedia(title,url) == true)
                {
                    int indexRemove;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].name == title && list[i].url == url)
                        {
                            indexRemove = i;
                            break;
                        }
                    }

                    list.RemoveAt(index);
                    DataGridViewRow selectedRow = dataGridView1.Rows[index];
                    dataGridView1.Rows.Remove(selectedRow);
                }
                 
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPlaylistName.Text == "")
            {
                MessageBox.Show("You must enter name of playlist", "Name of playlist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Playlist pl = new Playlist();
            pl.medias = list;
        }
    }
}
