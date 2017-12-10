using ProjectCSharp.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectCSharp.CustomUI
{
    partial class CustomButton : Button
    {
        public int id { get; set; }
        public MainController ctrl { get; set; }

        public CustomButton()
        {
        }

        public void cancelDownload(Object sender, EventArgs e)
        {
            ctrl.cancelDownload(id);
        }
    }
}
