using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using WindowsFormsApp1;
using ProjectCSharp.GUIDynamic;

namespace ProjectCSharp.Utility
{
    public delegate void DDownload();
    class Download
    {
        event DDownload EDownload;

        public string download_url;
        public string storedir_url;
        private CustomProgressBar mpb;

        private DDownload D1;
        private DDownload D2;

        public Download(ref CustomProgressBar pb)
        {
            mpb = pb;

            EDownload += new DDownload(encodePath);
            D1 = new DDownload(downloadVideo);
            D2 = new DDownload(downloadMusic);
        }

        private void encodePath()
        {
            storedir_url = PathEncoder.NormalizePath(storedir_url);
        }

        public void dvid()
        {
            EDownload();
            D1();
        }

        public void downloadMusic()
        {
            String cmd = " --extract-audio --audio-format mp3 " + download_url + " -o " + storedir_url + "\\%(title)s.%(ext)s  --verbose --max-downloads 1 --newline";

            Process process = ProcessCtrl.mkp(@"youtube-dl.exe", cmd);

            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                string progress = line.Substring(10, 4);
                string text = line.Substring(12, line.Length - 12);

                int x = 0;
                int.TryParse(progress, out x);

                FormDownloadCG.setValue(mpb, x, text);
            }
       
        }

        public void downloadVideo()
        {
            download_url = "https://www.youtube.com/watch?v=azYEiOh_FFo";
            String cmd = download_url + " -o " + storedir_url + "\\%(title)s.%(ext)s --max-downloads 1 --newline";

            Process process = ProcessCtrl.mkp(@"youtube-dl.exe", cmd);
       
            while (!process.StandardOutput.EndOfStream)
            {
                string line = process.StandardOutput.ReadLine();
                string progress = line.Substring(10, 4);
                string text = line.Substring(12, line.Length - 12);

                int x = 0;
                int.TryParse(progress, out x);
                        
                FormDownloadCG.setValue(mpb, x, text);
                Console.WriteLine(mpb.Value);
            }
        }
    }
}
