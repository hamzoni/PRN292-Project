using ProjectCSharp.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class CustomProgressBar : ProgressBar
    {
        public Label lbn = new Label();
        public Panel gpn = new Panel();
        public CustomButton btn = new CustomButton();

        public CustomProgressBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
            
        }

        public void removeGUI()
        {
            lbn.Dispose();
            gpn.Dispose();
            btn.Dispose();
            this.Dispose();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Rectangle rect = this.ClientRectangle;
            Graphics g = pe.Graphics;
            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            if (this.Value > 0)
            {
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)this.Value / this.Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalBar(g, clip);
                pe.Graphics.FillRectangle(Brushes.Green, 2, 2, clip.Width, clip.Height);
            }
            using (Font f = new Font(FontFamily.GenericMonospace, 10))
            {
                SizeF size = g.MeasureString(string.Format("{0}", this.Value), f);
                Point location = new Point( 5 , (int)((rect.Height / 2) - (size.Height / 2) + 2));
                g.DrawString(Text, f, Brushes.Black, location);
            }
            base.OnPaint(pe);
        }
    }
}
