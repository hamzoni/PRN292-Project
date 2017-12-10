using ProjectCSharp.Controller;
using ProjectCSharp.Database;
using ProjectCSharp.Entities;
using ProjectCSharp.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

delegate void ButtonAction();
delegate void ButtonActionIS(string x, bool y);
delegate void ButtonActionII(int x);

namespace ProjectCSharp
{
    partial class FormMain : Form
    {
        private bool hide = true;
        
        public MainController ctrl;

        private ButtonAction A1;
        private ButtonAction A2;
        private ButtonActionIS A3;
        private ButtonAction A4;
        private ButtonActionII A5;

        public FormMain()
        {
            InitializeComponent();
            setup();
        }

        private void setup()
        {
            // setup controller
            ctrl = new MainController(this);
            
            // setup delegate
            A1 = new ButtonAction(ctrl.addVideo);
            A2 = new ButtonAction(ctrl.openPlayFolder);
            A3 = new ButtonActionIS(ctrl.downloadMedia);
            A4 = new ButtonAction(ctrl.openDownloadFolder);
            A5 = new ButtonActionII(ctrl.playVideo);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //function mainpanel silde
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hide == true)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= 180)
                {
                    timer1.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width <= 39)
                {
                    timer1.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }

        //effect move mouse
        //======================================================
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btn_profile.Font = new Font(btn_profile.Font.FontFamily, 16);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btn_profile.Font = new Font(btn_profile.Font.FontFamily, 12);
        }

  
        private void btnLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void lblUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnLogout.Visible = true;
        }
     
        private void btn_choosePlayFolder_Click_1(object sender, EventArgs e)
        {
            A2();
        }

        private void btn_add_Click_2(object sender, EventArgs e)
        {
            A1();
        }
        

        private void list_videos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            A5(list_videos.SelectedIndex);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            btn_profile.Enabled = true;
            lblUsername.Text = "";
            btnLogout.Visible = false;
        }

        private void btn_playList_Click(object sender, EventArgs e)
        {
            new FormPlayList(ctrl).Show();
        }

        private void btn_downloadManager_Click(object sender, EventArgs e)
        {
            ctrl.dlf.Show();
        }

        private void btn_dwndir_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            A3(input_url.Text, radio_movie.Checked);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctrl.closeAllProcesses();
            // Environment.Exit(0);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
