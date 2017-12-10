using ProjectCSharp.DAL;
using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using ProjectCSharp.GUI;
using ProjectCSharp.GUIDynamic;
using ProjectCSharp.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectCSharp.Controller
{
    class MainController
    {
        public Authentication auth;

        public List<string> videoUrls;
        public List<string> videoNames;
        public string playFolder;
        public string downloadFolder;
        public string videoUrl;

        public FormDownloadProgress dlf;
        private FormDownloadCG dlcg;
        private List<Download> dlt;

        public Playlist playlist;
        public FormMain gui;

        public MainController(FormMain gui)
        {
            this.gui = gui;
            this.auth = new Authentication(this);

            // Initialize variables
            videoUrls = new List<string>();
            videoNames = new List<string>();
            dlt = new List<Download>();

            // UI setting
            dlf = new FormDownloadProgress();
            dlf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dlcg = new FormDownloadCG(dlf, this);
            

            // get default folder
            downloadFolder = FolderCtrl.getDownloadDir();
            playFolder = FolderCtrl.getVideoDir();
            gui.input_dwndir.Text = downloadFolder;

            // listing video
            loadVideoList();
        }

        public void loadPlaylist(Playlist playlist)
        {
            resetVideoList();

            this.playlist = playlist;
            foreach (Media media in playlist.medias)
            {
                videoUrls.Add(media.url);
                videoNames.Add(media.name);
            }

            loadVideoPlaylist();

            gui.label_playlist.Text = playlist.name;
        }

        public void landing()
        {
 

            if (auth != null)
            {
                if (auth.account != null)
                {
                    if (auth.account.username != null)
                    {
                        gui.lblUsername.Text = " -   " + auth.account.username;
                    }
                }
            }
        }

        public void closeAllProcesses()
        {
            foreach (Download d in dlt)
            {
                if (d.p.HasExited)
                {
                    continue;
                }
                d.p.Kill();
                d.p.Close();
            }
        }

        public void cancelDownload(int id)
        {
            int index = -1;
            Download d = Download.findDownload(dlt, id, ref index);

            // close process
            if (!d.p.HasExited)
            {
                d.p.Kill();
                d.p.Close();
            }

            // clear component UI
            dlt.RemoveAt(index);
            d.mpb.removeGUI();
            dlcg.pbars.RemoveAt(index);

            // update main form UI
            int h = FormDownloadCG.blkh;
            dlf.Height = h * (dlt.Count + 1) + 10;

            for (int i = index; i < dlt.Count; i++)
            {
                dlt[i].mpb.gpn.Location = new System.Drawing.Point(
                        dlt[i].mpb.gpn.Location.X,
                        h * i + 10
                    );
            }
        }

        public void downloadMedia(string url, bool isMovie)
        {
            Download dtt = new Download();
            dtt.download_url = url;
            dtt.storedir_url = downloadFolder;
            dtt.isMovie = isMovie;
            dtt.mpb = dlcg.addProgressbar("Loading...");

            ThreadStart ts = new ThreadStart(dtt.dvid);
            Thread t = new Thread(ts);

            dlt.Add(dtt);

            // show Progress bar in UI
            dlf.Show();
            t.Start();
        }

        public void resetVideoList()
        {
            videoUrls = new List<string>();
            videoNames = new List<string>();
        }

        public void addVideo()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string file = "";

            DialogResult result = dlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = dlg.FileName;
            }

            videoUrls.Add(file);

            string fn = Path.GetFileName(file);
            videoNames.Add(fn);
            gui.list_videos.Items.Add(fn);
        }

        public void openDownloadFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    downloadFolder = fbd.SelectedPath;
                }
            }
            gui.input_dwndir.Text = downloadFolder;
        }

        public void openPlayFolder()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrEmpty(fbd.SelectedPath))
                {
                    resetVideoList();
                    playFolder = fbd.SelectedPath;
                    loadVideoList();
                }
            }
        }

        // load video from a playlist
        public void loadVideoPlaylist()
        {
            gui.list_videos.Items.Clear();
            foreach (String name in videoNames)
            {
                gui.list_videos.Items.Add(name);
            }
        }

        // load video from a folder
        public void loadVideoList()
        {
            string[] files = Directory.GetFiles(playFolder);
            gui.list_videos.Items.Clear();
            foreach (String file in files)
            {
                string ext = Path.GetExtension(file);
                if (!FolderCtrl.isValidFile(ext)) continue;
                videoUrls.Add(@file);

                string fn = Path.GetFileName(file);
                videoNames.Add(fn);
                gui.list_videos.Items.Add(fn);
            }
        }

        public void playVideo(int index)
        {
            if (index < 0 || index >= videoUrls.Count) return;
            string path = videoUrls[index];
            gui.tv.URL = @path;
        }
    }
}
     