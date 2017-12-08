using ProjectCSharp.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApp1;
using System.Windows.Forms;

namespace ProjectCSharp.GUIDynamic
{
    // Component generator
    class FormDownloadCG
    {
        private FormDownloadProgress gui;
        public List<CustomProgressBar> pbars { get; }
        public List<Label> pgname { get; }
        public List<Panel> gpanel { get; }

        public FormDownloadCG(FormDownloadProgress gui)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            // Initialize variables
            this.gui = gui;
            pbars = new List<CustomProgressBar>();
            pgname = new List<Label>();
            gpanel = new List<Panel>();

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
            Label lbn = new Label();
            Panel gpn = new Panel();
            gpn.SuspendLayout();

            int index = pbars.Count();
            // 
            // progress bar
            // 
            pgb.Location = new System.Drawing.Point(0, 20);
            pgb.Name = "progressbar_" + index;
            pgb.Size = new System.Drawing.Size(300, 20);
            pgb.TabIndex = 1;
            
            // 
            // label
            // 
            lbn.AutoSize = true;
            lbn.Location = new System.Drawing.Point(0, 0);
            lbn.Name = "label_" + index;
            lbn.Size = new System.Drawing.Size(300, 15);
            lbn.TabIndex = 2;
            lbn.Text = pname;
            // 
            // panel
            // 
            gpn.Controls.Add(pgb);
            gpn.Controls.Add(lbn);

            int gph = pgb.ClientSize.Height + lbn.ClientSize.Height + 10;
            gpn.Location = new System.Drawing.Point(10, gph * index + 10);
            gpn.Name = "panel_" + index;
            gpn.Size = new System.Drawing.Size(pgb.ClientSize.Width + 10, gph);
            gpn.TabIndex = 3;
            // 
            // form
            //
            int w = gpn.ClientSize.Width + 10;
            int h = gpn.ClientSize.Height * (index + 1);

            gui.ClientSize = new System.Drawing.Size(w, h + 20);
            gui.ResumeLayout(false);
            gui.PerformLayout();
            gui.Controls.Add(gpn);

            // add to existing controller
            pbars.Add(pgb);
            pgname.Add(lbn);
            gpanel.Add(gpn);

            return pgb;
        }
    }
}
