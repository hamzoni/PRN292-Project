using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Utility
{
    class ProcessCtrl
    {
        public static Process mkp(string app, string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(app, cmd);
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            process.StartInfo.UseShellExecute = false;
            process.Start();
            return process;
        }
    }
}
