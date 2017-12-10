using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WindowsFormsApp1;
using ProjectCSharp.GUIDynamic;
using ProjectCSharp.Controller;

namespace ProjectCSharp.Utility
{
    public delegate void DDownload();
    class Download
    {
        event DDownload EDownload;

        public static int id = 0;
        public int cid;

        public string download_url;
        public string storedir_url;
        public bool isMovie;

        public CustomProgressBar mpb;
        public MainController ctrl;

        private DDownload D1;
        private DDownload D2;

        public Process p;

        public Download(MainController ctrl)
        {
            Download.id += 1;
            this.cid = Download.id;
            this.ctrl = ctrl;

            EDownload += new DDownload(encodePath);
            D1 = new DDownload(downloadVideo);
            D2 = new DDownload(downloadMusic);
        }

        public void downloadFinish()
        {
            ctrl.cancelDownload(id);
        }

        public static Download findDownload(List<Download> dl, int id, ref int i)
        {
            for (int j = 0; j < dl.Count; j++)
            {
                if (dl[j].cid == id)
                {
                    i = j;
                    return dl[j];
                }
            }
            return null;
        }

        private void encodePath()
        {
            storedir_url = PathEncoder.NormalizePath(storedir_url);
        }

        public void dvid()
        {
            EDownload();
            if (isMovie)
            {
                D1();
            } else
            {
                D2();
            }
        }

        public void downloadMusic()
        {
            String cmd = " --extract-audio --audio-format mp3 " + download_url + " -o " + storedir_url + "\\%(title)s.%(ext)s  --max-downloads 1 --newline";
            p = ProcessCtrl.mkp(@"youtube-dl.exe", cmd);

            mpb.lbn.Text = getTitle();

            if (p == null) return;
            try
            {
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine();
                    string progress = line.Substring(10, 4);
                    string text = line.Substring(12, line.Length - 12);

                    int x = 0;
                    int.TryParse(progress, out x);

                    FormDownloadCG.setValue(mpb, x, text);
                }
            } catch (Exception exp)
            {

            }
            downloadFinish();
        }

        public string getTitle()
        {
            String cmd = download_url + " -o " + storedir_url + "\\%(title)s.%(ext)s --get-title --max-downloads 1 --newline";
            Process process = ProcessCtrl.mkp(@"youtube-dl.exe", cmd);
            while (!process.StandardOutput.EndOfStream)
            {
                return process.StandardOutput.ReadLine();
            }
            return "Untitled";
            
        }

        public void downloadVideo()
        {
            // download_url = "https://www.youtube.com/watch?v=wI__53kBBKM";

            String cmd = download_url + " -o " + storedir_url + "\\%(title)s.%(ext)s --max-downloads 1 --newline";
            p = ProcessCtrl.mkp(@"youtube-dl.exe", cmd);
            
            mpb.lbn.Text = getTitle();

            if (p == null) return;
            try
            {
                while (!p.StandardOutput.EndOfStream)
                {
                    string line = p.StandardOutput.ReadLine();
                    string progress = line.Substring(10, 4);
                    string text = line.Substring(12, line.Length - 12);

                    int x = 0;
                    int.TryParse(progress, out x);

                    FormDownloadCG.setValue(mpb, x, text);
                    // Console.WriteLine(mpb.Value);
                }
            } catch (Exception exp)
            {

            }
            downloadFinish();
        }
    }
}
