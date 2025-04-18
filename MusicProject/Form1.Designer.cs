namespace MusicPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.songListView = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Track = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnChangeMusicPath = new System.Windows.Forms.Button();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.slash = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.picAlbumArt = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.Drawer = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mainPanel.Controls.Add(this.songListView);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.Drawer);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(988, 625);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // songListView
            // 
            this.songListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.songListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.songListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Artist,
            this.Album,
            this.Duration,
            this.Year,
            this.Track});
            this.songListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songListView.ForeColor = System.Drawing.Color.White;
            this.songListView.FullRowSelect = true;
            this.songListView.HideSelection = false;
            this.songListView.Location = new System.Drawing.Point(146, 191);
            this.songListView.Name = "songListView";
            this.songListView.Size = new System.Drawing.Size(842, 345);
            this.songListView.TabIndex = 1;
            this.songListView.UseCompatibleStateImageBehavior = false;
            this.songListView.View = System.Windows.Forms.View.Details;
            this.songListView.SelectedIndexChanged += new System.EventHandler(this.songListView_SelectedIndexChanged);
            this.songListView.DoubleClick += new System.EventHandler(this.songListView_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 243;
            // 
            // Artist
            // 
            this.Artist.DisplayIndex = 5;
            this.Artist.Text = "Artist";
            this.Artist.Width = 232;
            // 
            // Album
            // 
            this.Album.DisplayIndex = 4;
            this.Album.Text = "Album";
            this.Album.Width = 111;
            // 
            // Duration
            // 
            this.Duration.DisplayIndex = 1;
            this.Duration.Text = "Duration";
            this.Duration.Width = 133;
            // 
            // Year
            // 
            this.Year.DisplayIndex = 2;
            this.Year.Text = "Year";
            this.Year.Width = 62;
            // 
            // Track
            // 
            this.Track.DisplayIndex = 3;
            this.Track.Text = "Track";
            this.Track.Width = 56;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.controlsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(146, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 89);
            this.panel1.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(673, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 89);
            this.panel5.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnChangeMusicPath);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 99);
            this.panel4.TabIndex = 7;
            // 
            // btnChangeMusicPath
            // 
            this.btnChangeMusicPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChangeMusicPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMusicPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeMusicPath.Location = new System.Drawing.Point(3, 63);
            this.btnChangeMusicPath.Name = "btnChangeMusicPath";
            this.btnChangeMusicPath.Size = new System.Drawing.Size(84, 23);
            this.btnChangeMusicPath.TabIndex = 7;
            this.btnChangeMusicPath.Text = "Music Path";
            this.btnChangeMusicPath.UseVisualStyleBackColor = false;
            this.btnChangeMusicPath.Click += new System.EventHandler(this.btnChangeMusicPath_Click);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.seekBar);
            this.controlsPanel.Controls.Add(this.btnNext);
            this.controlsPanel.Controls.Add(this.lblTotalTime);
            this.controlsPanel.Controls.Add(this.slash);
            this.controlsPanel.Controls.Add(this.lblCurrentTime);
            this.controlsPanel.Controls.Add(this.btnPlayPause);
            this.controlsPanel.Location = new System.Drawing.Point(250, 3);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(417, 88);
            this.controlsPanel.TabIndex = 6;
            // 
            // seekBar
            // 
            this.seekBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.seekBar.Location = new System.Drawing.Point(10, 47);
            this.seekBar.Maximum = 0;
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(372, 45);
            this.seekBar.TabIndex = 1;
            this.seekBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.seekBar.Scroll += new System.EventHandler(this.seekBar_Scroll);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(239, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 38);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "⏭";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(121, 10);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(50, 21);
            this.lblTotalTime.TabIndex = 4;
            this.lblTotalTime.Text = "00:00";
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.slash.Location = new System.Drawing.Point(98, 10);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(17, 21);
            this.slash.TabIndex = 3;
            this.slash.Text = "/";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(42, 10);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(50, 21);
            this.lblCurrentTime.TabIndex = 2;
            this.lblCurrentTime.Text = "00:00";
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(180, 3);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(40, 38);
            this.btnPlayPause.TabIndex = 0;
            this.btnPlayPause.Text = "▶";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.headerPanel.Controls.Add(this.panel3);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.headerPanel.Location = new System.Drawing.Point(146, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(842, 191);
            this.headerPanel.TabIndex = 0;
            // 
            // picAlbumArt
            // 
            this.picAlbumArt.BackColor = System.Drawing.Color.Transparent;
            this.picAlbumArt.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAlbumArt.Location = new System.Drawing.Point(0, 0);
            this.picAlbumArt.Margin = new System.Windows.Forms.Padding(0);
            this.picAlbumArt.Name = "picAlbumArt";
            this.picAlbumArt.Size = new System.Drawing.Size(189, 178);
            this.picAlbumArt.TabIndex = 0;
            this.picAlbumArt.TabStop = false;
            this.picAlbumArt.Click += new System.EventHandler(this.picAlbumArt_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picAlbumArt);
            this.panel3.Controls.Add(this.lblNowPlaying);
            this.panel3.Controls.Add(this.lblArtist);
            this.panel3.Controls.Add(this.lblAlbumName);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(737, 178);
            this.panel3.TabIndex = 5;
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.ForeColor = System.Drawing.Color.White;
            this.lblNowPlaying.Location = new System.Drawing.Point(192, 6);
            this.lblNowPlaying.Name = "lblNowPlaying";
            this.lblNowPlaying.Size = new System.Drawing.Size(64, 30);
            this.lblNowPlaying.TabIndex = 4;
            this.lblNowPlaying.Text = "Song";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.Silver;
            this.lblArtist.Location = new System.Drawing.Point(192, 82);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(61, 25);
            this.lblArtist.TabIndex = 5;
            this.lblArtist.Text = "Artist";
            // 
            // lblAlbumName
            // 
            this.lblAlbumName.AutoSize = true;
            this.lblAlbumName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlbumName.ForeColor = System.Drawing.Color.Silver;
            this.lblAlbumName.Location = new System.Drawing.Point(192, 45);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(71, 25);
            this.lblAlbumName.TabIndex = 6;
            this.lblAlbumName.Text = "Album";
            // 
            // Drawer
            // 
            this.Drawer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Drawer.Location = new System.Drawing.Point(0, 0);
            this.Drawer.Name = "Drawer";
            this.Drawer.Size = new System.Drawing.Size(146, 625);
            this.Drawer.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 625);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MeloDy";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label slash;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar seekBar;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.ListView songListView;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Artist;
        private System.Windows.Forms.ColumnHeader Album;
        private System.Windows.Forms.ColumnHeader Duration;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Track;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnChangeMusicPath;
        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.PictureBox picAlbumArt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblNowPlaying;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbumName;
        private System.Windows.Forms.Panel Drawer;
    }
}

