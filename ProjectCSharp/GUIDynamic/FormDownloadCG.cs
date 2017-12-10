using ProjectCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1;
using System.Windows.Forms;
using ProjectCSharp.Controller;
using ProjectCSharp.Utility;

namespace ProjectCSharp.GUIDynamic
{
    // Component generator
    class FormDownloadCG
    {
        private FormDownloadProgress gui;
        public List<CustomProgressBar> pbars { get; }
        private MainController ctrl;

        public static int blkh;

        public FormDownloadCG(FormDownloadProgress gui, MainController ctrl)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            // Initialize variables
            this.gui = gui;
            this.ctrl = ctrl;
            pbars = new List<CustomProgressBar>();

            // styling form
            gui.SuspendLayout();
            gui.Text = "Downloader";
        }

        public static void setValue(CustomProgressBar pb, int v, string text)
        {
            pb.Maximum = 100;
            pb.Minimum = 0;
            pb.Value = v;
            pb.Text = text;
        }

        // pname: progress name
        public CustomProgressBar addProgressbar(string pname)
        {
            // Initialize variables
            CustomProgressBar pgb = new CustomProgressBar();
            pgb.gpn.SuspendLayout();

            int index = pbars.Count();
            // 
            // progress bar
            // 
            pgb.Location = new System.Drawing.Point(0, 20);
            pgb.Name = "progressbar_" + index;
            pgb.Size = new System.Drawing.Size(300, 20);
            pgb.TabIndex = 1;

            // 
            // button cancel
            // 
            pgb.btn.Location = new System.Drawing.Point(310, 20);
            pgb.btn.Name = "btn_" + index;
            pgb.btn.Size = new System.Drawing.Size(60, 20);
            pgb.btn.TabIndex = 4;
            pgb.btn.Text = "Cancel";
            pgb.btn.id = Download.id;
            pgb.btn.ctrl = ctrl;
            pgb.btn.Click += new EventHandler(pgb.btn.cancelDownload);

            // 
            // label
            // 
            pgb.lbn.AutoSize = true;
            pgb.lbn.Location = new System.Drawing.Point(0, 0);
            pgb.lbn.Name = "label_" + index;
            pgb.lbn.Size = new System.Drawing.Size(300, 15);
            pgb.lbn.TabIndex = 2;
            pgb.lbn.Text = pname;
            // 
            // panel
            // 
            pgb.gpn.Controls.Add(pgb);
            pgb.gpn.Controls.Add(pgb.lbn);
            pgb.gpn.Controls.Add(pgb.btn);

            int gph = pgb.ClientSize.Height + pgb.lbn.ClientSize.Height + 10;
            int gpw = pgb.ClientSize.Width + pgb.btn.ClientSize.Width + 20;

            pgb.gpn.Location = new System.Drawing.Point(10, gph * index + 10);
            pgb.gpn.Name = "panel_" + index;
            pgb.gpn.Size = new System.Drawing.Size(gpw, gph);
            pgb.gpn.TabIndex = 3;
            // 
            // form
            //
            int w = pgb.gpn.ClientSize.Width + 10;
            int h = pgb.gpn.ClientSize.Height * (index + 1);
            FormDownloadCG.blkh = pgb.gpn.ClientSize.Height;

            gui.ClientSize = new System.Drawing.Size(w, h + 20);
            gui.ResumeLayout(false);
            gui.PerformLayout();
            gui.Controls.Add(pgb.gpn);

            // add to existing controller
            pbars.Add(pgb);

            return pgb;
        }
    }
}
