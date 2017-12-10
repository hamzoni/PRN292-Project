using ProjectCSharp.Utility;

namespace ProjectCSharp
{
    partial class FormPlayList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayList));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewDetail = new System.Windows.Forms.Button();
            this.list_playlists = new System.Windows.Forms.DataGridView();
            this.btnNewPlaylist = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Label();
            this.btn_choosePlaylist = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.list_playlists)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 4);
            this.panel2.TabIndex = 1;
            // 
            // btnViewDetail
            // 
            this.btnViewDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnViewDetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewDetail.BackgroundImage")));
            this.btnViewDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewDetail.FlatAppearance.BorderSize = 0;
            this.btnViewDetail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewDetail.ForeColor = System.Drawing.Color.White;
            this.btnViewDetail.Location = new System.Drawing.Point(277, 382);
            this.btnViewDetail.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetail.Name = "btnViewDetail";
            this.btnViewDetail.Size = new System.Drawing.Size(94, 36);
            this.btnViewDetail.TabIndex = 7;
            this.btnViewDetail.TabStop = false;
            this.btnViewDetail.Text = "Detail";
            this.btnViewDetail.UseVisualStyleBackColor = false;
            this.btnViewDetail.Click += new System.EventHandler(this.btnViewDetail_Click);
            // 
            // list_playlists
            // 
            this.list_playlists.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.list_playlists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_playlists.Location = new System.Drawing.Point(11, 126);
            this.list_playlists.Margin = new System.Windows.Forms.Padding(2);
            this.list_playlists.Name = "list_playlists";
            this.list_playlists.Size = new System.Drawing.Size(360, 252);
            this.list_playlists.TabIndex = 8;
            // 
            // btnNewPlaylist
            // 
            this.btnNewPlaylist.AutoSize = true;
            this.btnNewPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnNewPlaylist.Image = ((System.Drawing.Image)(resources.GetObject("btnNewPlaylist.Image")));
            this.btnNewPlaylist.Location = new System.Drawing.Point(10, 81);
            this.btnNewPlaylist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnNewPlaylist.Name = "btnNewPlaylist";
            this.btnNewPlaylist.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnNewPlaylist.Size = new System.Drawing.Size(69, 24);
            this.btnNewPlaylist.TabIndex = 11;
            this.btnNewPlaylist.Text = "New";
            this.btnNewPlaylist.Click += new System.EventHandler(this.btnNewPlaylist_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(93, 81);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnEdit.Size = new System.Drawing.Size(62, 24);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(168, 81);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnDelete.Size = new System.Drawing.Size(84, 24);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btn_choosePlaylist
            // 
            this.btn_choosePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btn_choosePlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_choosePlaylist.BackgroundImage")));
            this.btn_choosePlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_choosePlaylist.FlatAppearance.BorderSize = 0;
            this.btn_choosePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_choosePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choosePlaylist.ForeColor = System.Drawing.Color.White;
            this.btn_choosePlaylist.Location = new System.Drawing.Point(172, 382);
            this.btn_choosePlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.btn_choosePlaylist.Name = "btn_choosePlaylist";
            this.btn_choosePlaylist.Size = new System.Drawing.Size(94, 36);
            this.btn_choosePlaylist.TabIndex = 15;
            this.btn_choosePlaylist.TabStop = false;
            this.btn_choosePlaylist.Text = "Choose";
            this.btn_choosePlaylist.UseVisualStyleBackColor = false;
            this.btn_choosePlaylist.Click += new System.EventHandler(this.btn_choosePlaylist_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147682;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 27);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(362, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tekton Pro Ext", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(151, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Playlist";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // FormPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = global::ProjectCSharp.Properties.Resources.beautiful_old_natural_wooden_texture_vintage_dark_background_wood_cracks_fading_860147681;
            this.ClientSize = new System.Drawing.Size(383, 429);
            this.Controls.Add(this.btn_choosePlaylist);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNewPlaylist);
            this.Controls.Add(this.list_playlists);
            this.Controls.Add(this.btnViewDetail);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimizeBox = false;
            this.Name = "FormPlayList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSavePlayList";
            ((System.ComponentModel.ISupportInitialize)(this.list_playlists)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.DataGridView list_playlists;
        private System.Windows.Forms.Label btnNewPlaylist;
        private System.Windows.Forms.Label btnEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnDelete;
        private System.Windows.Forms.Button btn_choosePlaylist;

        public object UIDetail { get; private set; }
    }
}