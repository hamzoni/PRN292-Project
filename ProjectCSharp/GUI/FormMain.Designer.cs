namespace ProjectCSharp
{
    partial class FormMain
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxMail = new System.Windows.Forms.PictureBox();
            this.picBoxFacebook = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.main_panel = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.television = new AxWMPLib.AxWindowsMediaPlayer();
            this.list_videos = new System.Windows.Forms.ListBox();
            this.btn_choosePlayFolder = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.input_dwndir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dwndir = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.input_url = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_playlist = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).BeginInit();
            this.main_panel.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.television)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 39);
            this.panel3.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(231, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(66, 24);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "label2";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(902, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 27);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(41, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(177, 24);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Media Application";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectCSharp.Properties.Resources.PlayIcon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Teal;
            this.panelSlide.Controls.Add(this.btnVideo);
            this.panelSlide.Controls.Add(this.btnSong);
            this.panelSlide.Controls.Add(this.btnLogin);
            this.panelSlide.Controls.Add(this.panel1);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 39);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(32, 657);
            this.panelSlide.TabIndex = 2;
            // 
            // btnVideo
            // 
            this.btnVideo.Enabled = false;
            this.btnVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVideo.Image = global::ProjectCSharp.Properties.Resources.youtube_32;
            this.btnVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVideo.Location = new System.Drawing.Point(31, 126);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(168, 38);
            this.btnVideo.TabIndex = 5;
            this.btnVideo.Text = "Video";
            this.btnVideo.UseVisualStyleBackColor = true;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            this.btnVideo.MouseLeave += new System.EventHandler(this.btnVideo_MouseLeave);
            this.btnVideo.MouseHover += new System.EventHandler(this.btnVideo_MouseHover);
            // 
            // btnSong
            // 
            this.btnSong.Enabled = false;
            this.btnSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSong.Image = global::ProjectCSharp.Properties.Resources._156_32;
            this.btnSong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSong.Location = new System.Drawing.Point(31, 82);
            this.btnSong.Name = "btnSong";
            this.btnSong.Size = new System.Drawing.Size(168, 38);
            this.btnSong.TabIndex = 3;
            this.btnSong.Text = "Song";
            this.btnSong.UseVisualStyleBackColor = true;
            this.btnSong.Click += new System.EventHandler(this.btnSong_Click);
            this.btnSong.MouseLeave += new System.EventHandler(this.btnSong_MouseLeave);
            this.btnSong.MouseHover += new System.EventHandler(this.btnSong_MouseHover);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Image = global::ProjectCSharp.Properties.Resources.login_1_32;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(31, 38);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(168, 38);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseLeave += new System.EventHandler(this.btnLogin_MouseLeave);
            this.btnLogin.MouseHover += new System.EventHandler(this.btnLogin_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.picBoxMail);
            this.panel1.Controls.Add(this.picBoxFacebook);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 657);
            this.panel1.TabIndex = 0;
            // 
            // picBoxMail
            // 
            this.picBoxMail.Image = global::ProjectCSharp.Properties.Resources.gmail_48;
            this.picBoxMail.Location = new System.Drawing.Point(0, 617);
            this.picBoxMail.Name = "picBoxMail";
            this.picBoxMail.Size = new System.Drawing.Size(32, 32);
            this.picBoxMail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxMail.TabIndex = 8;
            this.picBoxMail.TabStop = false;
            // 
            // picBoxFacebook
            // 
            this.picBoxFacebook.Image = global::ProjectCSharp.Properties.Resources.square_facebook_32;
            this.picBoxFacebook.Location = new System.Drawing.Point(0, 579);
            this.picBoxFacebook.Name = "picBoxFacebook";
            this.picBoxFacebook.Size = new System.Drawing.Size(32, 32);
            this.picBoxFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxFacebook.TabIndex = 7;
            this.picBoxFacebook.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenu.Image = global::ProjectCSharp.Properties.Resources.menuIcon4;
            this.btnMenu.Location = new System.Drawing.Point(0, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 32);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.tabPage2);
            this.main_panel.Controls.Add(this.tabPage1);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(32, 39);
            this.main_panel.Name = "main_panel";
            this.main_panel.SelectedIndex = 0;
            this.main_panel.Size = new System.Drawing.Size(957, 657);
            this.main_panel.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(949, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "s";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_playlist);
            this.panel2.Controls.Add(this.television);
            this.panel2.Controls.Add(this.list_videos);
            this.panel2.Controls.Add(this.btn_choosePlayFolder);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.input_dwndir);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_dwndir);
            this.panel2.Controls.Add(this.btn_download);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.input_url);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 619);
            this.panel2.TabIndex = 1;
            // 
            // television
            // 
            this.television.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.television.Enabled = true;
            this.television.Location = new System.Drawing.Point(129, 3);
            this.television.Name = "television";
            this.television.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("television.OcxState")));
            this.television.Size = new System.Drawing.Size(803, 550);
            this.television.TabIndex = 23;
            // 
            // list_videos
            // 
            this.list_videos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list_videos.FormattingEnabled = true;
            this.list_videos.Location = new System.Drawing.Point(3, 29);
            this.list_videos.Name = "list_videos";
            this.list_videos.Size = new System.Drawing.Size(120, 524);
            this.list_videos.TabIndex = 22;
            this.list_videos.SelectedIndexChanged += new System.EventHandler(this.list_videos_SelectedIndexChanged);
            // 
            // btn_choosePlayFolder
            // 
            this.btn_choosePlayFolder.Location = new System.Drawing.Point(1, 590);
            this.btn_choosePlayFolder.Name = "btn_choosePlayFolder";
            this.btn_choosePlayFolder.Size = new System.Drawing.Size(121, 21);
            this.btn_choosePlayFolder.TabIndex = 21;
            this.btn_choosePlayFolder.Text = "Choose Folder";
            this.btn_choosePlayFolder.UseVisualStyleBackColor = true;
            this.btn_choosePlayFolder.Click += new System.EventHandler(this.btn_choosePlayFolder_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(1, 561);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(122, 22);
            this.btn_add.TabIndex = 20;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // input_dwndir
            // 
            this.input_dwndir.Location = new System.Drawing.Point(245, 591);
            this.input_dwndir.Name = "input_dwndir";
            this.input_dwndir.Size = new System.Drawing.Size(469, 20);
            this.input_dwndir.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Download Folder:";
            // 
            // btn_dwndir
            // 
            this.btn_dwndir.Location = new System.Drawing.Point(720, 591);
            this.btn_dwndir.Name = "btn_dwndir";
            this.btn_dwndir.Size = new System.Drawing.Size(75, 21);
            this.btn_dwndir.TabIndex = 17;
            this.btn_dwndir.Text = "Change";
            this.btn_dwndir.UseVisualStyleBackColor = true;
            this.btn_dwndir.Click += new System.EventHandler(this.btn_dwndir_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(720, 562);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(75, 23);
            this.btn_download.TabIndex = 16;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 567);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Youtube URL";
            // 
            // input_url
            // 
            this.input_url.Location = new System.Drawing.Point(245, 563);
            this.input_url.Name = "input_url";
            this.input_url.Size = new System.Drawing.Size(469, 20);
            this.input_url.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(949, 631);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Location = new System.Drawing.Point(7, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(935, 619);
            this.panel4.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(129, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(803, 550);
            this.axWindowsMediaPlayer1.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 550);
            this.listBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 21);
            this.button1.TabIndex = 21;
            this.button1.Text = "Choose Folder";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 22);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 591);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 594);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Download Folder:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 591);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 17;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(720, 562);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Download";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 567);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Youtube URL";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(245, 563);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(469, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.Location = new System.Drawing.Point(4, 10);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(14, 13);
            this.label_playlist.TabIndex = 24;
            this.label_playlist.Text = "#";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(989, 696);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel3);
            this.Name = "FormMain";
            this.Text = "MusicApp";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFacebook)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.television)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btnMenu;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel panelSlide;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button btnSong;
        public System.Windows.Forms.Button btnVideo;
        public System.Windows.Forms.PictureBox picBoxMail;
        public System.Windows.Forms.PictureBox picBoxFacebook;
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btnLogout;
        public System.Windows.Forms.TabControl main_panel;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.Panel panel2;
        public AxWMPLib.AxWindowsMediaPlayer television;
        public System.Windows.Forms.ListBox list_videos;
        public System.Windows.Forms.Button btn_choosePlayFolder;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TextBox input_dwndir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_dwndir;
        public System.Windows.Forms.Button btn_download;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox input_url;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.Panel panel4;
        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_playlist;
    }
}

