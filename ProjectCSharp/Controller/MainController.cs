using ProjectCSharp.DAL;
using ProjectCSharp.Database;
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

        private FormDownloadProgress dlf;
        private FormDownloadCG dlcg;
        private List<Download> dlt;
        private List<ThreadStart> dts;
        private List<Thread> dt;

        public FormMain gui;

        public MainController(FormMain gui)
        {
            this.gui = gui;

            auth = new Authentication(this);

            landing();

            // Initialize variables
            videoUrls = new List<string>();
            videoNames = new List<string>();
            dlt = new List<Download>();
            dts = new List<ThreadStart>();
            dt = new List<Thread>();

            // UI setting
            dlf = new FormDownloadProgress();
            dlcg = new FormDownloadCG(dlf);
            

            // get default folder
            downloadFolder = FolderCtrl.getDownloadDir();
            playFolder = FolderCtrl.getVideoDir();
            gui.input_dwndir.Text = downloadFolder;

            // listing video
            loadVideoList();
        }

        public void landing()
        {
            gui.btnLogin.Enabled = false;
            gui.btnSong.Enabled = true;
            gui.btnVideo.Enabled = true;
            gui.btnLogout.Visible = true;

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

        public void downloadVideo(string url)
        {
            CustomProgressBar pgb = dlcg.addProgressbar("A");
            
            Download dtt = new Download(ref pgb);
            dtt.download_url = url;
            dtt.storedir_url = downloadFolder;

            ThreadStart ts = new ThreadStart(dtt.dvid);
            Thread t = new Thread(ts);

            dlt.Add(dtt);
            dts.Add(ts);
            dt.Add(t);

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

        public void loadVideoList()
        {
            string[] files = Directory.GetFiles(playFolder);
            gui.list_videos.Items.Clear();
            foreach (String file in files)
            {
                string ext = Path.GetExtension(file);
                if (!FolderCtrl.isValidFile(ext)) continue;
                videoUrls.Add(file);

                string fn = Path.GetFileName(file);
                videoNames.Add(fn);
                gui.list_videos.Items.Add(fn);
            }
        }

        public void playVideo(int index)
        {
            string path = videoUrls[index];
            gui.television.URL = @path;
        }
    }
}
     