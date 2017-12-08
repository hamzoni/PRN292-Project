using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectCSharp.Utility
{
    class MSG
    {
        public static void error(string msg, string title)
        {
            msg = msg == null ? "Error" : msg;
            title = title == null ? "Error" : title;
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void success(string msg, string title)
        {
            msg = msg == null ? "Success" : msg;
            title = title == null ? "Success" : title;
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
