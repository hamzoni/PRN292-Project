using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Utility
{
    class FolderCtrl
    {
        public static string getVideoDir()
        {
            string usn = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] lines = usn.Split(new char[] { '\\' });
            return "C: \\Users\\" + lines[1] + "\\Videos";
        }

        public static string getDownloadDir()
        {
            string usn = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string[] lines = usn.Split(new char[] { '\\' });
            return "C: \\Users\\" + lines[1] + "\\Downloads";
        }

        public static bool isValidFile(string fn)
        {
            string[] exts = new string[] {
                ".asf", ".asx", ".avi", ".wav",
                ".wax", ".wma", ".wm", ".wmv",
                ".m3u", ".mp2v", ".mpg", ".mpeg",
                ".m1v", ".mp2", ".mp3", ".mpa",
                ".mpe", ".mpv2", ".mp4", ".webm",
            };
            return Array.IndexOf(exts, fn) != -1;
        }
    }
}
