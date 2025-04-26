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
            this.visualizerPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.slash = new System.Windows.Forms.Label();
            this.seekBar = new System.Windows.Forms.TrackBar();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTracksIcon = new System.Windows.Forms.Label();
            this.lblTimeIcon = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblTotalPlayTime = new System.Windows.Forms.Label();
            this.cmbSearchType = new System.Windows.Forms.ComboBox();
            this.lblTotalTracks = new System.Windows.Forms.Label();
            this.picAlbumArt = new System.Windows.Forms.PictureBox();
            this.lblNowPlaying = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbumName = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Panel();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnAddSongsToPlaylist = new System.Windows.Forms.Button();
            this.btnAddPlaylist = new System.Windows.Forms.Button();
            this.playlistListBox = new System.Windows.Forms.ListBox();
            this.btnSyncCache = new System.Windows.Forms.Button();
            this.btnChangeMusicPath = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).BeginInit();
            this.v.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.mainPanel.Controls.Add(this.songListView);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.headerPanel);
            this.mainPanel.Controls.Add(this.v);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(988, 625);
            this.mainPanel.TabIndex = 0;
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
            this.songListView.DoubleClick += new System.EventHandler(this.songListView_DoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 218;
            // 
            // Artist
            // 
            this.Artist.DisplayIndex = 5;
            this.Artist.Text = "Artist";
            this.Artist.Width = 170;
            // 
            // Album
            // 
            this.Album.DisplayIndex = 4;
            this.Album.Text = "Album";
            this.Album.Width = 200;
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
            this.Year.Width = 50;
            // 
            // Track
            // 
            this.Track.DisplayIndex = 3;
            this.Track.Text = "Track";
            this.Track.Width = 50;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.visualizerPanel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.controlsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(146, 536);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 89);
            this.panel1.TabIndex = 2;
            // 
            // visualizerPanel
            // 
            this.visualizerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.visualizerPanel.Location = new System.Drawing.Point(647, 0);
            this.visualizerPanel.Name = "visualizerPanel";
            this.visualizerPanel.Size = new System.Drawing.Size(195, 89);
            this.visualizerPanel.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 99);
            this.panel4.TabIndex = 7;
            // 
            // controlsPanel
            // 
            this.controlsPanel.Controls.Add(this.lblTotalTime);
            this.controlsPanel.Controls.Add(this.lblCurrentTime);
            this.controlsPanel.Controls.Add(this.btnPrevious);
            this.controlsPanel.Controls.Add(this.slash);
            this.controlsPanel.Controls.Add(this.seekBar);
            this.controlsPanel.Controls.Add(this.btnNext);
            this.controlsPanel.Controls.Add(this.btnPlayPause);
            this.controlsPanel.Location = new System.Drawing.Point(206, 7);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(435, 88);
            this.controlsPanel.TabIndex = 6;
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalTime.Location = new System.Drawing.Point(377, 18);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(50, 21);
            this.lblTotalTime.TabIndex = 4;
            this.lblTotalTime.Text = "00:00";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.Color.White;
            this.lblCurrentTime.Location = new System.Drawing.Point(298, 18);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(50, 21);
            this.lblCurrentTime.TabIndex = 2;
            this.lblCurrentTime.Text = "00:00";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(129, 10);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 38);
            this.btnPrevious.TabIndex = 6;
            this.btnPrevious.Text = "⏪";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // slash
            // 
            this.slash.AutoSize = true;
            this.slash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slash.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.slash.Location = new System.Drawing.Point(354, 18);
            this.slash.Name = "slash";
            this.slash.Size = new System.Drawing.Size(17, 21);
            this.slash.TabIndex = 3;
            this.slash.Text = "/";
            // 
            // seekBar
            // 
            this.seekBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.seekBar.Location = new System.Drawing.Point(10, 53);
            this.seekBar.Maximum = 0;
            this.seekBar.Name = "seekBar";
            this.seekBar.Size = new System.Drawing.Size(422, 45);
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
            this.btnNext.Location = new System.Drawing.Point(245, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 38);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "⏩";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(187, 10);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblTracksIcon);
            this.panel3.Controls.Add(this.lblTimeIcon);
            this.panel3.Controls.Add(this.btnClearSearch);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.lblTotalPlayTime);
            this.panel3.Controls.Add(this.cmbSearchType);
            this.panel3.Controls.Add(this.lblTotalTracks);
            this.panel3.Controls.Add(this.picAlbumArt);
            this.panel3.Controls.Add(this.lblNowPlaying);
            this.panel3.Controls.Add(this.lblArtist);
            this.panel3.Controls.Add(this.lblAlbumName);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(839, 188);
            this.panel3.TabIndex = 5;
            // 
            // lblTracksIcon
            // 
            this.lblTracksIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTracksIcon.AutoSize = true;
            this.lblTracksIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTracksIcon.ForeColor = System.Drawing.Color.White;
            this.lblTracksIcon.Location = new System.Drawing.Point(235, 155);
            this.lblTracksIcon.Name = "lblTracksIcon";
            this.lblTracksIcon.Size = new System.Drawing.Size(24, 21);
            this.lblTracksIcon.TabIndex = 17;
            this.lblTracksIcon.Text = "○";
            // 
            // lblTimeIcon
            // 
            this.lblTimeIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimeIcon.AutoSize = true;
            this.lblTimeIcon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeIcon.ForeColor = System.Drawing.Color.White;
            this.lblTimeIcon.Location = new System.Drawing.Point(379, 155);
            this.lblTimeIcon.Name = "lblTimeIcon";
            this.lblTimeIcon.Size = new System.Drawing.Size(25, 21);
            this.lblTimeIcon.TabIndex = 16;
            this.lblTimeIcon.Text = "◷";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearSearch.Location = new System.Drawing.Point(709, 36);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(56, 21);
            this.btnClearSearch.TabIndex = 15;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(771, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 21);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(615, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(212, 20);
            this.txtSearch.TabIndex = 13;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTotalPlayTime
            // 
            this.lblTotalPlayTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalPlayTime.AutoSize = true;
            this.lblTotalPlayTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPlayTime.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlayTime.Location = new System.Drawing.Point(403, 155);
            this.lblTotalPlayTime.Name = "lblTotalPlayTime";
            this.lblTotalPlayTime.Size = new System.Drawing.Size(76, 21);
            this.lblTotalPlayTime.TabIndex = 9;
            this.lblTotalPlayTime.Text = " 00:32:02";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.Items.AddRange(new object[] {
            "Title",
            "Artist",
            "Album"});
            this.cmbSearchType.Location = new System.Drawing.Point(615, 36);
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(88, 21);
            this.cmbSearchType.TabIndex = 12;
            // 
            // lblTotalTracks
            // 
            this.lblTotalTracks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalTracks.AutoSize = true;
            this.lblTotalTracks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTracks.ForeColor = System.Drawing.Color.White;
            this.lblTotalTracks.Location = new System.Drawing.Point(257, 155);
            this.lblTotalTracks.Name = "lblTotalTracks";
            this.lblTotalTracks.Size = new System.Drawing.Size(83, 21);
            this.lblTotalTracks.TabIndex = 8;
            this.lblTotalTracks.Text = " 20 Tracks";
            // 
            // picAlbumArt
            // 
            this.picAlbumArt.BackColor = System.Drawing.Color.Transparent;
            this.picAlbumArt.Dock = System.Windows.Forms.DockStyle.Left;
            this.picAlbumArt.Location = new System.Drawing.Point(0, 0);
            this.picAlbumArt.Margin = new System.Windows.Forms.Padding(0);
            this.picAlbumArt.Name = "picAlbumArt";
            this.picAlbumArt.Size = new System.Drawing.Size(189, 188);
            this.picAlbumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAlbumArt.TabIndex = 0;
            this.picAlbumArt.TabStop = false;
            this.picAlbumArt.Click += new System.EventHandler(this.picAlbumArt_Click);
            // 
            // lblNowPlaying
            // 
            this.lblNowPlaying.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNowPlaying.AutoSize = true;
            this.lblNowPlaying.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowPlaying.ForeColor = System.Drawing.Color.White;
            this.lblNowPlaying.Location = new System.Drawing.Point(198, 21);
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
            this.lblArtist.Location = new System.Drawing.Point(198, 103);
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
            this.lblAlbumName.Location = new System.Drawing.Point(198, 60);
            this.lblAlbumName.Name = "lblAlbumName";
            this.lblAlbumName.Size = new System.Drawing.Size(71, 25);
            this.lblAlbumName.TabIndex = 6;
            this.lblAlbumName.Text = "Album";
            // 
            // v
            // 
            this.v.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.v.Controls.Add(this.btnAddSong);
            this.v.Controls.Add(this.btnAddSongsToPlaylist);
            this.v.Controls.Add(this.btnAddPlaylist);
            this.v.Controls.Add(this.playlistListBox);
            this.v.Controls.Add(this.btnSyncCache);
            this.v.Controls.Add(this.btnChangeMusicPath);
            this.v.Dock = System.Windows.Forms.DockStyle.Left;
            this.v.Location = new System.Drawing.Point(0, 0);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(146, 625);
            this.v.TabIndex = 3;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(15, 429);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(75, 23);
            this.btnAddSong.TabIndex = 16;
            this.btnAddSong.Text = "add song ";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnAddSongsToPlaylist
            // 
            this.btnAddSongsToPlaylist.Location = new System.Drawing.Point(10, 378);
            this.btnAddSongsToPlaylist.Name = "btnAddSongsToPlaylist";
            this.btnAddSongsToPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnAddSongsToPlaylist.TabIndex = 15;
            this.btnAddSongsToPlaylist.Text = "delete";
            this.btnAddSongsToPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.Location = new System.Drawing.Point(15, 349);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnAddPlaylist.TabIndex = 14;
            this.btnAddPlaylist.Text = "add";
            this.btnAddPlaylist.UseVisualStyleBackColor = true;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // playlistListBox
            // 
            this.playlistListBox.FormattingEnabled = true;
            this.playlistListBox.Location = new System.Drawing.Point(15, 265);
            this.playlistListBox.Name = "playlistListBox";
            this.playlistListBox.Size = new System.Drawing.Size(108, 69);
            this.playlistListBox.TabIndex = 13;
            this.playlistListBox.SelectedIndexChanged += new System.EventHandler(this.playlistListBox_SelectedIndexChanged);
            // 
            // btnSyncCache
            // 
            this.btnSyncCache.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSyncCache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSyncCache.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSyncCache.Location = new System.Drawing.Point(29, 556);
            this.btnSyncCache.Name = "btnSyncCache";
            this.btnSyncCache.Size = new System.Drawing.Size(84, 23);
            this.btnSyncCache.TabIndex = 12;
            this.btnSyncCache.Text = "Sync Library";
            this.btnSyncCache.UseVisualStyleBackColor = false;
            this.btnSyncCache.Click += new System.EventHandler(this.btnSyncCache_Click);
            // 
            // btnChangeMusicPath
            // 
            this.btnChangeMusicPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnChangeMusicPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMusicPath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangeMusicPath.Location = new System.Drawing.Point(29, 588);
            this.btnChangeMusicPath.Name = "btnChangeMusicPath";
            this.btnChangeMusicPath.Size = new System.Drawing.Size(84, 23);
            this.btnChangeMusicPath.TabIndex = 7;
            this.btnChangeMusicPath.Text = "Music Path";
            this.btnChangeMusicPath.UseVisualStyleBackColor = false;
            this.btnChangeMusicPath.Click += new System.EventHandler(this.btnChangeMusicPath_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 625);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1004, 664);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1004, 664);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeloDy";
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seekBar)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumArt)).EndInit();
            this.v.ResumeLayout(false);
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
        private System.Windows.Forms.Panel visualizerPanel;
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
        private System.Windows.Forms.Panel v;
        private System.Windows.Forms.Label lblTotalPlayTime;
        private System.Windows.Forms.Label lblTotalTracks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearchType;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label lblTracksIcon;
        private System.Windows.Forms.Label lblTimeIcon;
        private System.Windows.Forms.Button btnSyncCache;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnAddSongsToPlaylist;
        private System.Windows.Forms.Button btnAddPlaylist;
        private System.Windows.Forms.ListBox playlistListBox;
        private System.Windows.Forms.Button btnAddSong;
    }
}

