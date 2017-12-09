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
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelSlide = new System.Windows.Forms.Panel();
            this.btnVideo = new System.Windows.Forms.Button();
            this.btnSong = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.list_videos = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_playlist = new System.Windows.Forms.Label();
            this.tv = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_download = new System.Windows.Forms.Button();
            this.input_dwndir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.input_url = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dwndir = new System.Windows.Forms.Button();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_choosePlayFolder = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.lblTitle);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 39);
            this.panel3.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(693, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
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
            this.panelSlide.Size = new System.Drawing.Size(32, 534);
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
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 534);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(32, 39);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(761, 534);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.59789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40212F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tv, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.15703F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.84298F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 524);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 445);
            this.panel4.TabIndex = 41;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.list_videos);
            this.panel6.Location = new System.Drawing.Point(3, 41);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(112, 401);
            this.panel6.TabIndex = 43;
            // 
            // list_videos
            // 
            this.list_videos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.list_videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_videos.FormattingEnabled = true;
            this.list_videos.Location = new System.Drawing.Point(0, 0);
            this.list_videos.Name = "list_videos";
            this.list_videos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_videos.Size = new System.Drawing.Size(112, 401);
            this.list_videos.TabIndex = 32;
            this.list_videos.SelectedIndexChanged += new System.EventHandler(this.list_videos_SelectedIndexChanged_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_playlist);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(118, 35);
            this.panel5.TabIndex = 42;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.ForeColor = System.Drawing.Color.Coral;
            this.label_playlist.Location = new System.Drawing.Point(3, 2);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(75, 24);
            this.label_playlist.TabIndex = 40;
            this.label_playlist.Text = "#playlist";
            this.label_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Enabled = true;
            this.tv.Location = new System.Drawing.Point(127, 3);
            this.tv.Name = "tv";
            this.tv.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tv.OcxState")));
            this.tv.Size = new System.Drawing.Size(622, 445);
            this.tv.TabIndex = 43;
            this.tv.Enter += new System.EventHandler(this.tv_Enter);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78907F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.21093F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_playlist, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(127, 454);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(622, 67);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20593F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.79407F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.Controls.Add(this.btn_download, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.input_dwndir, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.input_url, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_dwndir, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(506, 61);
            this.tableLayoutPanel3.TabIndex = 38;
            // 
            // btn_download
            // 
            this.btn_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_download.Location = new System.Drawing.Point(406, 33);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(97, 25);
            this.btn_download.TabIndex = 42;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click_1);
            // 
            // input_dwndir
            // 
            this.input_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_dwndir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_dwndir.Location = new System.Drawing.Point(101, 3);
            this.input_dwndir.Name = "input_dwndir";
            this.input_dwndir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_dwndir.Size = new System.Drawing.Size(299, 26);
            this.input_dwndir.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Download Folder";
            // 
            // input_url
            // 
            this.input_url.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_url.Location = new System.Drawing.Point(101, 33);
            this.input_url.Name = "input_url";
            this.input_url.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_url.Size = new System.Drawing.Size(299, 26);
            this.input_url.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Youtube URL";
            // 
            // btn_dwndir
            // 
            this.btn_dwndir.AutoSize = true;
            this.btn_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dwndir.Location = new System.Drawing.Point(406, 3);
            this.btn_dwndir.Name = "btn_dwndir";
            this.btn_dwndir.Size = new System.Drawing.Size(97, 24);
            this.btn_dwndir.TabIndex = 43;
            this.btn_dwndir.Text = "Change";
            this.btn_dwndir.UseVisualStyleBackColor = true;
            this.btn_dwndir.Click += new System.EventHandler(this.btn_dwndir_Click_2);
            // 
            // btn_playlist
            // 
            this.btn_playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_playlist.Location = new System.Drawing.Point(515, 3);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(104, 61);
            this.btn_playlist.TabIndex = 37;
            this.btn_playlist.Text = "Playlist";
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_add, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_choosePlayFolder, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 454);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(118, 67);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(3, 36);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 28);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_2);
            // 
            // btn_choosePlayFolder
            // 
            this.btn_choosePlayFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_choosePlayFolder.Location = new System.Drawing.Point(3, 3);
            this.btn_choosePlayFolder.Name = "btn_choosePlayFolder";
            this.btn_choosePlayFolder.Size = new System.Drawing.Size(112, 27);
            this.btn_choosePlayFolder.TabIndex = 38;
            this.btn_choosePlayFolder.Text = "Choose Folder";
            this.btn_choosePlayFolder.UseVisualStyleBackColor = true;
            this.btn_choosePlayFolder.Click += new System.EventHandler(this.btn_choosePlayFolder_Click_1);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(793, 573);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel3);
            this.Name = "FormMain";
            this.Text = "MusicApp";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
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
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btn_playlist;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label_playlist;
        public System.Windows.Forms.ListBox list_videos;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Panel panel6;
        public AxWMPLib.AxWindowsMediaPlayer tv;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_choosePlayFolder;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        public System.Windows.Forms.Button btn_download;
        public System.Windows.Forms.Button btn_dwndir;
        public System.Windows.Forms.TextBox input_dwndir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox input_url;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnLogout;
        private System.ComponentModel.IContainer components;
    }
}

