using ProjectCSharp.DAL;
using ProjectCSharp.Entities;
using ProjectCSharp.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectCSharp.GUI
{
    partial class FormEditPlaylist : Form
    {

        private Playlist oldPL;
        private Playlist newPL;
        private FormPlayList gui;

        public FormEditPlaylist()
        {
            InitializeComponent();
        }

        public FormEditPlaylist(Playlist playlist, FormPlayList gui)
        {
            InitializeComponent();
            this.oldPL = DataHelper.clone<Playlist>(playlist);
            this.newPL = DataHelper.clone<Playlist>(playlist);
            this.gui = gui;
            setup();
        }

        private void setup()
        {
            input_playlistName.Text = newPL.name;

            list_medias.ColumnCount = 3;
            list_medias.Columns[0].Name = "ID";
            list_medias.Columns[1].Name = "Name";
            list_medias.Columns[2].Name = "URL";
            loadMediaList();
        }

        public void loadMediaList()
        {
            list_medias.Rows.Clear();
            foreach (Media media in newPL.medias)
            {
                list_medias.Rows.Add(new object[] {
                    media.id, media.name, media.url
                });
            }
        }

        Point lastPoint;
        private object fn;

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(-e.X, -e.Y);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // set playlist name
            newPL.name = input_playlistName.Text;

            // remote deleted media in old list
            List<int> dId = new List<int>();
            foreach (Media m in oldPL.medias)
            {
                bool existed = false;
                for (int i = 0; i < newPL.medias.Count; i++)
                {
                    if (newPL.medias[i].url.Equals(m.url))
                    {
                        existed = true;
                        break;
                    }
                }
                if (!existed)
                {
                    dId.Add(m.id);
                }
            }
            // delete medias in database
            foreach (int id in dId)
            {
                DataModel.plmedMdl.deleteByMedia(id);
                DataModel.medMdl.delete(id);
            }

            // remove duplicated medias in new list
            List<int> indices = new List<int>();
            List<Media> updMds = new List<Media>();
            foreach (Media i in oldPL.medias)
            {
                for (int j = 0; j < newPL.medias.Count; j++)
                {
                    if (newPL.medias[j].url.Equals(i.url))
                    {
                        if (!newPL.medias[j].name.Equals(i.name))
                        {
                            updMds.Add(newPL.medias[j]);
                        }
                        indices.Add(j);
                    }
                }
            }
            indices.Sort();
            indices.Reverse();
            foreach (int i in indices)
            {
                newPL.medias.RemoveAt(i);
            }
            // Update medias
            foreach (Media m in updMds)
            {
                DataModel.medMdl.update(m);
            }

            // Add media to database
            foreach (Media m in newPL.medias)
            {
                int mediaID = DataModel.medMdl.insertGetId(m);

                // Add relationship of media and playlist
                PlaylistMedia plm = new PlaylistMedia();
                plm.media.id = mediaID;
                plm.playlist.id = newPL.id;
                DataModel.plmedMdl.insert(plm);
            }
            // Update name of playlist
            DataModel.plMdl.update(newPL);

            // Close window , notify parent window for update list
            gui.loadPlaylists();
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<int> indices = UIHelper.getSelectedIndices(list_medias);
            indices.Sort();
            indices.Reverse();

            foreach (int index in indices)
            {
                // delete in view
                list_medias.Rows.RemoveAt(index);

                // delete in memory
                newPL.medias.RemoveAt(index);
            }
        }

        public bool checkDuplicated(string url)
        {
            foreach (Media item in newPL.medias)
            {
                if (item.url == url)
                    return true;
            }
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.ShowDialog();

            string[] files = dlg.FileNames;
            foreach (string f in files)
            {
                TagLib.File tagFile = TagLib.File.Create(f);
                string title = tagFile.Tag.Title;
                string url = f.ToString();

                if (!checkDuplicated(url))
                {
                    Media media = new Media();
                    media.name = title;

                    if (string.IsNullOrEmpty(title))
                    {
                        media.name = Path.GetFileName(f);
                    }

                    media.url = url;
                    media.type = true;

                    newPL.medias.Add(media);
                    loadMediaList();
                }
                else
                {
                    MessageBox.Show("This media already exist is your playlist", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void list_medias_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void list_medias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string newName = (string)list_medias.Rows[e.RowIndex].Cells[1].Value;
            newPL.medias[e.RowIndex].name = newName;
        }
    }
}
