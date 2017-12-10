using ProjectCSharp.Utility;

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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_playList = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_downloadManager = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tv = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.checkbox_stopAutoLogin = new System.Windows.Forms.CheckBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv)).BeginInit();
            this.panelSlide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_playList,
            this.btn_downloadManager});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(167, 124);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_playList
            // 
            this.btn_playList.Name = "btn_playList";
            this.btn_playList.Size = new System.Drawing.Size(160, 4);
            // 
            // btn_downloadManager
            // 
            this.btn_downloadManager.Name = "btn_downloadManager";
            this.btn_downloadManager.Size = new System.Drawing.Size(160, 4);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(32, 39);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(958, 577);
            this.panel2.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
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
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.Teal;
            this.panelSlide.BackgroundImage = global::ProjectCSharp.Properties.Resources.ivy_1394991_960_720;
            this.panelSlide.Controls.Add(this.panel1);
            this.panelSlide.Controls.Add(this.menuStrip2);
            this.panelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlide.Location = new System.Drawing.Point(0, 39);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(32, 577);
            this.panelSlide.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_86014768;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(33, 577);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ProjectCSharp.Properties.Resources._3_red_cherry_png_image_download_thumb;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.downloaderToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(-115, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(147, 577);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.profileToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileToolStripMenuItem.BackgroundImage")));
            this.profileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileToolStripMenuItem.Image = global::ProjectCSharp.Properties.Resources.strawberry_icon;
            this.profileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.profileToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.profileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(134, 42);
            this.profileToolStripMenuItem.Text = "Profile";
            this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.playlistToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("playlistToolStripMenuItem.BackgroundImage")));
            this.playlistToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.playlistToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlistToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playlistToolStripMenuItem.Image = global::ProjectCSharp.Properties.Resources._55b6fc5f52ba0b759000632d_icon_256x256;
            this.playlistToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.playlistToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playlistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(134, 42);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // downloaderToolStripMenuItem
            // 
            this.downloaderToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.downloaderToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloaderToolStripMenuItem.BackgroundImage")));
            this.downloaderToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloaderToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloaderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.downloaderToolStripMenuItem.Image = global::ProjectCSharp.Properties.Resources._543720afe1272f6e82000116_icon_256x256;
            this.downloaderToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.downloaderToolStripMenuItem.Name = "downloaderToolStripMenuItem";
            this.downloaderToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.downloaderToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.downloaderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.downloaderToolStripMenuItem.Size = new System.Drawing.Size(134, 42);
            this.downloaderToolStripMenuItem.Text = "Downloader";
            this.downloaderToolStripMenuItem.Click += new System.EventHandler(this.downloaderToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147682;
            this.panel4.Controls.Add(this.tableLayoutPanel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(158, 501);
            this.panel4.TabIndex = 41;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.label_playlist, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.list_videos, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.97804F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.02196F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(158, 501);
            this.tableLayoutPanel6.TabIndex = 41;
            // 
            // label_playlist
            // 
            this.label_playlist.AutoSize = true;
            this.label_playlist.BackColor = System.Drawing.Color.Transparent;
            this.label_playlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playlist.ForeColor = System.Drawing.Color.Coral;
            this.label_playlist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_playlist.Location = new System.Drawing.Point(3, 0);
            this.label_playlist.Name = "label_playlist";
            this.label_playlist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_playlist.Size = new System.Drawing.Size(152, 54);
            this.label_playlist.TabIndex = 40;
            this.label_playlist.Text = "QT";
            this.label_playlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list_videos
            // 
            this.list_videos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.list_videos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_videos.FormattingEnabled = true;
            this.list_videos.Location = new System.Drawing.Point(0, 54);
            this.list_videos.Margin = new System.Windows.Forms.Padding(0);
            this.list_videos.Name = "list_videos";
            this.list_videos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.list_videos.Size = new System.Drawing.Size(158, 447);
            this.list_videos.TabIndex = 32;
            this.list_videos.SelectedIndexChanged += new System.EventHandler(this.list_videos_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147685;
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
            this.tableLayoutPanel3.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147682;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20593F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.79407F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
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
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 416F));
            this.tableLayoutPanel5.Controls.Add(this.radio_music, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.radio_movie, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.input_url, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(98, 38);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(525, 38);
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
            this.radio_music.Location = new System.Drawing.Point(53, 0);
            this.radio_music.Margin = new System.Windows.Forms.Padding(0);
            this.radio_music.Name = "radio_music";
            this.radio_music.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radio_music.Size = new System.Drawing.Size(55, 38);
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
            this.radio_movie.Size = new System.Drawing.Size(53, 38);
            this.radio_movie.TabIndex = 41;
            this.radio_movie.TabStop = true;
            this.radio_movie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radio_movie.UseVisualStyleBackColor = false;
            // 
            // input_url
            // 
            this.input_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_url.Location = new System.Drawing.Point(108, 0);
            this.input_url.Margin = new System.Windows.Forms.Padding(0);
            this.input_url.Multiline = true;
            this.input_url.Name = "input_url";
            this.input_url.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_url.Size = new System.Drawing.Size(417, 38);
            this.input_url.TabIndex = 40;
            // 
            // btn_download
            // 
            this.btn_download.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_download.BackgroundImage")));
            this.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_download.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_download.ForeColor = System.Drawing.Color.White;
            this.btn_download.Location = new System.Drawing.Point(623, 38);
            this.btn_download.Margin = new System.Windows.Forms.Padding(0);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(177, 38);
            this.btn_download.TabIndex = 42;
            this.btn_download.Text = "Download";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // input_dwndir
            // 
            this.input_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_dwndir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_dwndir.Location = new System.Drawing.Point(98, 0);
            this.input_dwndir.Margin = new System.Windows.Forms.Padding(0);
            this.input_dwndir.Multiline = true;
            this.input_dwndir.Name = "input_dwndir";
            this.input_dwndir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_dwndir.Size = new System.Drawing.Size(525, 38);
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
            this.label1.Size = new System.Drawing.Size(92, 13);
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
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Youtube URL";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_dwndir
            // 
            this.btn_dwndir.AutoSize = true;
            this.btn_dwndir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_dwndir.BackgroundImage")));
            this.btn_dwndir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dwndir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dwndir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_dwndir.ForeColor = System.Drawing.Color.White;
            this.btn_dwndir.Location = new System.Drawing.Point(623, 0);
            this.btn_dwndir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dwndir.Name = "btn_dwndir";
            this.btn_dwndir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_dwndir.Size = new System.Drawing.Size(177, 38);
            this.btn_dwndir.TabIndex = 43;
            this.btn_dwndir.Text = "Change";
            this.btn_dwndir.UseVisualStyleBackColor = true;
            this.btn_dwndir.Click += new System.EventHandler(this.btn_dwndir_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147682;
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
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::ProjectCSharp.Properties.Resources.add;
            this.btn_add.Location = new System.Drawing.Point(0, 38);
            this.btn_add.Margin = new System.Windows.Forms.Padding(0);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(158, 38);
            this.btn_add.TabIndex = 37;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click_2);
            // 
            // btn_choosePlayFolder
            // 
            this.btn_choosePlayFolder.BackgroundImage = global::ProjectCSharp.Properties.Resources._018972_glossy_waxed_wood_icon_symbols_shapes_minimize2;
            this.btn_choosePlayFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_choosePlayFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_choosePlayFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_choosePlayFolder.ForeColor = System.Drawing.Color.White;
            this.btn_choosePlayFolder.Image = global::ProjectCSharp.Properties.Resources.folder;
            this.btn_choosePlayFolder.Location = new System.Drawing.Point(0, 0);
            this.btn_choosePlayFolder.Margin = new System.Windows.Forms.Padding(0);
            this.btn_choosePlayFolder.Name = "btn_choosePlayFolder";
            this.btn_choosePlayFolder.Size = new System.Drawing.Size(158, 38);
            this.btn_choosePlayFolder.TabIndex = 38;
            this.btn_choosePlayFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_choosePlayFolder.UseVisualStyleBackColor = true;
            this.btn_choosePlayFolder.Click += new System.EventHandler(this.btn_choosePlayFolder_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147684;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.checkbox_stopAutoLogin);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.lblUsername);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 39);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::ProjectCSharp.Properties.Resources.coollogo_com_2568242;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(38, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(601, 39);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // checkbox_stopAutoLogin
            // 
            this.checkbox_stopAutoLogin.AutoSize = true;
            this.checkbox_stopAutoLogin.BackColor = System.Drawing.Color.Transparent;
            this.checkbox_stopAutoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkbox_stopAutoLogin.ForeColor = System.Drawing.Color.Red;
            this.checkbox_stopAutoLogin.Location = new System.Drawing.Point(846, 12);
            this.checkbox_stopAutoLogin.Name = "checkbox_stopAutoLogin";
            this.checkbox_stopAutoLogin.Size = new System.Drawing.Size(108, 17);
            this.checkbox_stopAutoLogin.TabIndex = 7;
            this.checkbox_stopAutoLogin.Text = "Disable auto login";
            this.checkbox_stopAutoLogin.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::ProjectCSharp.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogout.Location = new System.Drawing.Point(957, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(5);
            this.btnLogout.Size = new System.Drawing.Size(33, 30);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TabStop = false;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(645, 5);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(21, 24);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "#";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjectCSharp.Properties.Resources.doremon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(990, 616);
            this.Controls.Add(this.panelSlide);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MusicApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv)).EndInit();
            this.panelSlide.ResumeLayout(false);
            this.panelSlide.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Timer timer1;
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
        public System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloaderToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.CheckBox checkbox_stopAutoLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}

