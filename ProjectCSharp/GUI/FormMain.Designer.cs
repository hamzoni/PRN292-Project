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
            this.panel5 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_profile = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_playList = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_downloadManager = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_playlist = new System.Windows.Forms.Label();
            this.list_videos = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.radio_music = new System.Windows.Forms.RadioButton();
            this.radio_movie = new System.Windows.Forms.RadioButton();
            this.input_url = new System.Windows.Forms.TextBox();
            this.btn_download = new System.Windows.Forms.Button();
            this.input_dwndir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dwndir = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_choosePlayFolder = new System.Windows.Forms.Button();
            this.tv = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.panel5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
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
            this.panel3.Size = new System.Drawing.Size(990, 39);
            this.panel3.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(912, 10);
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
            this.panelSlide.Controls.Add(this.panel5);
            this.panelSlide.Controls.Add(this.panel1);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 39);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(32, 577);
            this.panelSlide.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.menuStrip1);
            this.panel5.Location = new System.Drawing.Point(34, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 124);
            this.panel5.TabIndex = 41;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_profile,
            this.btn_playList,
            this.btn_downloadManager});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(167, 124);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btn_profile
            // 
<<<<<<< HEAD
            this.btn_profile.Location = new System.Drawing.Point(35, 45);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(152, 40);
            this.btn_profile.TabIndex = 3;
            this.btn_profile.TabStop = false;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
=======
            this.btn_profile.AutoSize = false;
            this.btn_profile.BackColor = System.Drawing.Color.LightGray;
            this.btn_profile.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.btn_profile.Size = new System.Drawing.Size(168, 40);
            this.btn_profile.Text = "Profile";
            // 
            // btn_playList
            // 
            this.btn_playList.AutoSize = false;
            this.btn_playList.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_playList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playList.Name = "btn_playList";
            this.btn_playList.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.btn_playList.Size = new System.Drawing.Size(168, 40);
            this.btn_playList.Text = "Playlist";
            this.btn_playList.Click += new System.EventHandler(this.btn_playList_Click);
            // 
            // btn_downloadManager
            // 
            this.btn_downloadManager.AutoSize = false;
            this.btn_downloadManager.BackColor = System.Drawing.Color.LightGray;
            this.btn_downloadManager.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_downloadManager.Name = "btn_downloadManager";
            this.btn_downloadManager.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.btn_downloadManager.Size = new System.Drawing.Size(168, 40);
            this.btn_downloadManager.Text = "Download";
            this.btn_downloadManager.Click += new System.EventHandler(this.btn_downloadManager_Click);
            // 
            // panel1
            // 
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 577);
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
            this.panel2.Size = new System.Drawing.Size(958, 577);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.59789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.40212F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tv, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.94885F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.05115F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 577);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label_playlist);
            this.panel4.Controls.Add(this.list_videos);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 501);
            this.panel4.TabIndex = 41;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.ForeColor = System.Drawing.Color.Coral;
            this.label_playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_playlist.Location = new System.Drawing.Point(0, 0);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.Size = new System.Drawing.Size(75, 24);
            this.label_playlist.TabIndex = 40;
            this.label_playlist.Text = "#playlist";
            this.label_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_videos
            // 
            this.list_videos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.list_videos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.list_videos.FormattingEnabled = true;
            this.list_videos.Location = new System.Drawing.Point(0, 55);
            this.list_videos.Margin = new System.Windows.Forms.Padding(0);
            this.list_videos.Name = "list_videos";
            this.list_videos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_videos.Size = new System.Drawing.Size(158, 446);
            this.list_videos.TabIndex = 32;
            this.list_videos.SelectedIndexChanged += new System.EventHandler(this.list_videos_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.78907F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(158, 501);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 76);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20593F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.79407F));
<<<<<<< HEAD
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
=======
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_download, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.input_dwndir, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_dwndir, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(800, 76);
            this.tableLayoutPanel3.TabIndex = 39;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.67257F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.32743F));
<<<<<<< HEAD
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 442F));
=======
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 436F));
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.tableLayoutPanel5.Controls.Add(this.radio_music, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radio_movie, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.input_url, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.tableLayoutPanel5.Location = new System.Drawing.Point(124, 36);
=======
            this.tableLayoutPanel5.Location = new System.Drawing.Point(118, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
<<<<<<< HEAD
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(506, 37);
=======
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(510, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.tableLayoutPanel5.TabIndex = 40;
            // 
            // radio_music
            // 
            this.radio_music.AutoSize = true;
            this.radio_music.BackColor = System.Drawing.Color.Transparent;
            this.radio_music.BackgroundImage = global::ProjectCSharp.Properties.Resources.music_icon1;
            this.radio_music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radio_music.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radio_music.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
<<<<<<< HEAD
            this.radio_music.Location = new System.Drawing.Point(31, 0);
            this.radio_music.Margin = new System.Windows.Forms.Padding(0);
            this.radio_music.Name = "radio_music";
            this.radio_music.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radio_music.Size = new System.Drawing.Size(32, 37);
=======
            this.radio_music.Location = new System.Drawing.Point(36, 0);
            this.radio_music.Margin = new System.Windows.Forms.Padding(0);
            this.radio_music.Name = "radio_music";
            this.radio_music.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radio_music.Size = new System.Drawing.Size(37, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.radio_music.TabIndex = 40;
            this.radio_music.UseVisualStyleBackColor = false;
            // 
            // radio_movie
            // 
            this.radio_movie.AutoSize = true;
            this.radio_movie.BackColor = System.Drawing.Color.Transparent;
            this.radio_movie.BackgroundImage = global::ProjectCSharp.Properties.Resources.movie_icon1;
            this.radio_movie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.radio_movie.CausesValidation = false;
            this.radio_movie.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radio_movie.Checked = true;
            this.radio_movie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radio_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radio_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_movie.Location = new System.Drawing.Point(0, 0);
            this.radio_movie.Margin = new System.Windows.Forms.Padding(0);
            this.radio_movie.Name = "radio_movie";
            this.radio_movie.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.radio_movie.Size = new System.Drawing.Size(31, 37);
=======
            this.radio_movie.Size = new System.Drawing.Size(36, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.radio_movie.TabIndex = 41;
            this.radio_movie.TabStop = true;
            this.radio_movie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_movie.UseVisualStyleBackColor = false;
            // 
            // input_url
            // 
            this.input_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.input_url.Location = new System.Drawing.Point(63, 0);
=======
            this.input_url.Location = new System.Drawing.Point(73, 0);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.input_url.Margin = new System.Windows.Forms.Padding(0);
            this.input_url.Multiline = true;
            this.input_url.Name = "input_url";
            this.input_url.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.input_url.Size = new System.Drawing.Size(443, 37);
=======
            this.input_url.Size = new System.Drawing.Size(437, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.input_url.TabIndex = 40;
            // 
            // btn_download
            // 
            this.btn_download.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.btn_download.Location = new System.Drawing.Point(630, 36);
            this.btn_download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(170, 37);
=======
            this.btn_download.Location = new System.Drawing.Point(628, 38);
            this.btn_download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(172, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.btn_download.TabIndex = 42;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // input_dwndir
            // 
            this.input_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_dwndir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.input_dwndir.Location = new System.Drawing.Point(124, 0);
=======
            this.input_dwndir.Location = new System.Drawing.Point(118, 0);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.input_dwndir.Margin = new System.Windows.Forms.Padding(0);
            this.input_dwndir.Multiline = true;
            this.input_dwndir.Name = "input_dwndir";
            this.input_dwndir.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.input_dwndir.Size = new System.Drawing.Size(506, 36);
=======
            this.input_dwndir.Size = new System.Drawing.Size(510, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.input_dwndir.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.label1.Size = new System.Drawing.Size(118, 13);
=======
            this.label1.Size = new System.Drawing.Size(112, 13);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.label1.TabIndex = 44;
            this.label1.Text = "Download Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.label3.Size = new System.Drawing.Size(118, 13);
=======
            this.label3.Size = new System.Drawing.Size(112, 13);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.label3.TabIndex = 41;
            this.label3.Text = "Youtube URL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_dwndir
            // 
            this.btn_dwndir.AutoSize = true;
            this.btn_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dwndir.Location = new System.Drawing.Point(630, 0);
            this.btn_dwndir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dwndir.Name = "btn_dwndir";
            this.btn_dwndir.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.btn_dwndir.Size = new System.Drawing.Size(170, 36);
=======
            this.btn_dwndir.Size = new System.Drawing.Size(172, 38);
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
            this.btn_dwndir.TabIndex = 43;
            this.btn_dwndir.Text = "Change";
            this.btn_dwndir.UseVisualStyleBackColor = true;
            this.btn_dwndir.Click += new System.EventHandler(this.btn_dwndir_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_add, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btn_choosePlayFolder, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 501);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(158, 76);
            this.tableLayoutPanel4.TabIndex = 45;
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.Location = new System.Drawing.Point(0, 38);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(158, 38);
            this.btn_add.TabIndex = 37;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_2);
            // 
            // btn_choosePlayFolder
            // 
            this.btn_choosePlayFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_choosePlayFolder.Location = new System.Drawing.Point(0, 0);
            this.btn_choosePlayFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btn_choosePlayFolder.Name = "btn_choosePlayFolder";
            this.btn_choosePlayFolder.Size = new System.Drawing.Size(158, 38);
            this.btn_choosePlayFolder.TabIndex = 38;
            this.btn_choosePlayFolder.Text = "Choose Folder";
            this.btn_choosePlayFolder.UseVisualStyleBackColor = true;
            this.btn_choosePlayFolder.Click += new System.EventHandler(this.btn_choosePlayFolder_Click_1);
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Enabled = true;
            this.tv.Location = new System.Drawing.Point(158, 0);
            this.tv.Margin = new System.Windows.Forms.Padding(0);
            this.tv.Name = "tv";
            this.tv.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tv.OcxState")));
            this.tv.Size = new System.Drawing.Size(800, 501);
            this.tv.TabIndex = 46;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(990, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
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
        public System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label_playlist;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.Button btn_choosePlayFolder;
        public System.Windows.Forms.Button btnLogout;
        private System.ComponentModel.IContainer components;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        public System.Windows.Forms.RadioButton radio_music;
        public System.Windows.Forms.RadioButton radio_movie;
        public System.Windows.Forms.TextBox input_url;
        public System.Windows.Forms.Button btn_download;
        public System.Windows.Forms.TextBox input_dwndir;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_dwndir;
        public AxWMPLib.AxWindowsMediaPlayer tv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_downloadManager;
        private System.Windows.Forms.ToolStripMenuItem btn_playList;
        public System.Windows.Forms.ListBox list_videos;
<<<<<<< HEAD
        public System.Windows.Forms.Button btn_profile;
=======
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ToolStripMenuItem btn_profile;
>>>>>>> 4dd77404509f15b5296921772ca3c754a2e32ade
    }
}

