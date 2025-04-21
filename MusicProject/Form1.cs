using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;
using Microsoft.WindowsAPICodePack.Dialogs;
using NAudio.Wave;

//using TagLib;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        private string currentSongPath;

        private bool isPlaying = false;
        private bool isPaused = false;

        private Timer progressTimer;

        private string musicFolder;
        private string defaultMusicPathConfig = @".\musicPath.config";
        //private string playlistDirectory = @".\playlists";
        //List<Song> allSongs = new List<Song>();   



        public Form1()
        {
            InitializeComponent();

            SetupPlayer();
        }

        private void InitializeMusicFolder()
        {


            if (System.IO.File.Exists(defaultMusicPathConfig))
            {
                string directory = System.IO.File.ReadAllText(defaultMusicPathConfig);
                if (Directory.Exists(directory))
                {
                    musicFolder = directory;
                    cleanupSong();
                    LoadMusic();
                }


            }
            else
            {
                changeMusicPath();
            }


        }
        private void changeMusicPath()
        {
            using (var folderDialog = new CommonOpenFileDialog())
            {

                folderDialog.Title = "Please select the music path";
                folderDialog.IsFolderPicker = true;
                //folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    string selectedFolder = folderDialog.FileName;
                    if (Directory.Exists(selectedFolder))
                    {
                        musicFolder = selectedFolder;
                        System.IO.File.WriteAllText(defaultMusicPathConfig, musicFolder);
                        cleanupSong();
                        GenerateMusicXmlCache();
                        LoadMusic();
                    }
                    else
                    {
                        changeMusicPath();
                    }

                }
                //else
                //{
                //    MessageBox.Show("No folder selected - using default");
                //    cleanupSong();
                //    LoadMusic();
                //}
            }
        }
        private void SetupPlayer()
        {
            cmbSearchType.SelectedIndex = 0;
            progressTimer = new Timer { Interval = 1000 };
            progressTimer.Tick += ProgressTimer_Tick;

            if (songListView.Columns.Count == 0)
            {
                songListView.Columns.Add("Title", 200, HorizontalAlignment.Left);
                songListView.Columns.Add("Duration", 100, HorizontalAlignment.Right);
                songListView.Columns.Add("Album", 150, HorizontalAlignment.Left);
                //songListView.Columns.Add("Duration", 80, HorizontalAlignment.Right);
                songListView.Columns.Add("Year", 30, HorizontalAlignment.Right);
                songListView.Columns.Add("Track", 30, HorizontalAlignment.Right);

            }
            //songListView.Columns.Add("Title", 300);
            //songListView.Columns.Add("Duration", 100);
            songListView.FullRowSelect = true;
            songListView.View = View.Details;



            this.BackColor = Color.FromArgb(30, 30, 30);
            songListView.BackColor = Color.FromArgb(40, 40, 40);
            songListView.ForeColor = Color.White;

            InitializeMusicFolder();
        }

        private void LoadMusic()
        {
            songListView.Items.Clear();


            string cachePath = @".\musicCache.xml";
            if (!File.Exists(cachePath))
            {
                GenerateMusicXmlCache();
            }
            songListView.BeginUpdate();
            XmlDocument doc = new XmlDocument();
            doc.Load(cachePath);
            foreach (XmlNode node in doc.SelectNodes("//Song"))
            {
                var item = new ListViewItem(node.Attributes["Title"]?.Value ?? "Unknown Title");
                item.SubItems.Add(node.Attributes["Artist"]?.Value ?? "Unknown Artist");
                item.SubItems.Add(node.Attributes["Album"]?.Value ?? "Unknown Album");
                item.SubItems.Add(node.Attributes["Duration"]?.Value ?? "00:00");
                item.SubItems.Add(node.Attributes["Year"]?.Value ?? "");
                item.SubItems.Add(node.Attributes["Track"]?.Value ?? "");
                item.Tag = node.Attributes["Path"]?.Value;

                songListView.Items.Add(item);
            }
            songListView.EndUpdate();
            lblTotalTracks.Text = $"{songListView.Items.Count} Tracks";
            UpdateTotalPlayTime();
        }

        private void GenerateMusicXmlCache()
        {
            var musicFiles = Directory.GetFiles(musicFolder, "*.mp3", SearchOption.AllDirectories);
            var doc = new XmlDocument();
            var root = doc.CreateElement("Songs");
            doc.AppendChild(root);

            foreach (var file in musicFiles)
            {
                try
                {
                    var tagFile = TagLib.File.Create(file);
                    var songNode = doc.CreateElement("Song");
                    songNode.SetAttribute("Path", file);
                    songNode.SetAttribute("Title", tagFile.Tag.Title ?? Path.GetFileNameWithoutExtension(file));
                    songNode.SetAttribute("Album", tagFile.Tag.Album ?? "Unknown Album");
                    songNode.SetAttribute("Artist", tagFile.Tag.FirstPerformer ?? "Unknown Artist");
                    songNode.SetAttribute("Duration", tagFile.Properties.Duration.ToString(@"mm\:ss"));
                    songNode.SetAttribute("Year", tagFile.Tag.Year.ToString());
                    songNode.SetAttribute("Track", tagFile.Tag.Track.ToString());

                    root.AppendChild(songNode);
                }
                catch
                {
                }
            }

            string cachePath = @".\musicCache.xml";
            doc.Save(cachePath);
        }


        private void UpdateNowPlaying(string filePath)
        {
            if (!File.Exists(filePath)) return;

            try
            {
                var fileInfo = TagLib.File.Create(filePath);
                lblNowPlaying.Text = fileInfo.Tag.Title ?? Path.GetFileNameWithoutExtension(filePath);
                lblAlbumName.Text = fileInfo.Tag.Album ?? "Unknown Album";
                lblArtist.Text = fileInfo.Tag.FirstAlbumArtist ?? "Unknown Artist";

                if (fileInfo.Tag.Pictures.Length > 0)
                {
                    using (var ms = new MemoryStream(fileInfo.Tag.Pictures[0].Data.Data))
                    {
                        picAlbumArt.Image = Image.FromStream(ms);
                        picAlbumArt.SizeMode = PictureBoxSizeMode.Zoom;
                    }

                }
                else
                {
                    picAlbumArt.Image = null;
                }

                seekBar.Maximum = (int)audioFile.TotalTime.TotalSeconds;
                lblTotalTime.Text = audioFile.TotalTime.ToString(@"mm\:ss");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading metadata: {ex.Message}");
            }
        }


        private void PlaySong(string filePath)
        {
            try
            {

                cleanupSong();


                currentSongPath = filePath;
                audioFile = new AudioFileReader(filePath);
                outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();


                UpdateNowPlaying(filePath);
                progressTimer.Start();


                isPlaying = true;
                isPaused = false;
                btnPlayPause.Text = "❚❚";



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error playing song: {ex.Message}");
            }
        }

        private void ProgressTimer_Tick(object sender, EventArgs e)
        {
            if (audioFile != null && isPlaying && !isPaused)
            {

                seekBar.Value = (int)audioFile?.CurrentTime.TotalSeconds;
                lblCurrentTime.Text = audioFile?.CurrentTime.ToString(@"mm\:ss");


                if (audioFile?.CurrentTime >= audioFile?.TotalTime - TimeSpan.FromMilliseconds(500))
                {
                    PlayNextSong();
                }
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            if (songListView.SelectedItems.Count == 0 && isPlaying)
            {
                if (isPaused)
                    ResumeSong();
                else
                    PauseSong();
                return;
            }

            if (songListView.SelectedItems.Count > 0)
            {
                string selectedSong = songListView.SelectedItems[0].Tag.ToString();
                bool isSameSong = selectedSong == currentSongPath;

                if (!isPlaying || !isSameSong)
                {
                    PlaySong(selectedSong);
                }
                else if (!isPaused)
                {
                    PauseSong();
                }
                else
                {
                    ResumeSong();
                }
            }
        }
        private void PauseSong()
        {
            outputDevice?.Pause();
            isPaused = true;
            btnPlayPause.Text = "▶";
        }

        private void ResumeSong()
        {
            outputDevice?.Play();
            isPaused = false;
            btnPlayPause.Text = "❚❚";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            outputDevice?.Stop();
            isPlaying = false;
            isPaused = false;
            btnPlayPause.Text = "▶";
            seekBar.Value = 0;
            lblCurrentTime.Text = "00:00";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PlayNextSong();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PlayPreviousSong();
        }

        private void PlayNextSong()
        {
            if (songListView.Items.Count == 0) return;

            int nextIndex = 0;
            if (songListView.SelectedItems.Count > 0)
            {
                nextIndex = songListView.SelectedIndices[0] + 1;
                if (nextIndex >= songListView.Items.Count)
                {
                    nextIndex = 0;
                }

            }

            songListView.SelectedIndices.Clear();
            songListView.FocusedItem = null;

            songListView.Items[nextIndex].Selected = true;
            songListView.Items[nextIndex].Focused = true;
            songListView.EnsureVisible(nextIndex);

            PlaySong(songListView.Items[nextIndex].Tag.ToString());
        }

        //private void PlayPreviousSong()
        //{
        //    if (songListView.Items.Count == 0) return;

        //    int prevIndex = 0;
        //    if (songListView.SelectedItems.Count > 0)
        //    {

        //        prevIndex = songListView.SelectedIndices[0] - 1;
        //        if (prevIndex <= songListView.Items.Count)
        //        {
        //            prevIndex = 0;
        //        }

        //    }
        //    songListView.SelectedIndices.Clear();
        //    songListView.FocusedItem = null;

        //    songListView.Items[prevIndex].Selected = true;
        //    songListView.Items[prevIndex].Focused = true;
        //    songListView.EnsureVisible(prevIndex);
        //    PlaySong(songListView.Items[prevIndex].Tag.ToString());
        //}
        private void PlayPreviousSong()
        {
            if (songListView.Items.Count == 0) return;

            int prevIndex = songListView.Items.Count - 1; 
            if (songListView.SelectedItems.Count > 0)
            {
                prevIndex = songListView.SelectedIndices[0] - 1;
                if (prevIndex < 0) 
                {
                    prevIndex = songListView.Items.Count - 1; 
                }
            }

            songListView.SelectedIndices.Clear();
            songListView.FocusedItem = null;

            songListView.Items[prevIndex].Selected = true;
            songListView.Items[prevIndex].Focused = true;
            songListView.EnsureVisible(prevIndex);
            PlaySong(songListView.Items[prevIndex].Tag.ToString());
        }

        private void seekBar_Scroll(object sender, EventArgs e)
        {
            if (audioFile != null)
            {
                audioFile.CurrentTime = TimeSpan.FromSeconds(seekBar.Value);
            }
        }

        private void songListView_DoubleClick(object sender, EventArgs e)
        {
            if (songListView.SelectedItems.Count > 0)
            {
                PlaySong(songListView.SelectedItems[0].Tag.ToString());
            }
        }
        private void picAlbumArt_Click(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            progressTimer?.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
        }

        private void btnChangeMusicPath_Click(object sender, EventArgs e)
        {
            changeMusicPath();
        }
        private void cleanupSong()
        {
            outputDevice?.Stop();
            progressTimer.Stop();
            outputDevice?.Dispose();
            audioFile?.Dispose();
            lblNowPlaying.Text = "Song";
            lblAlbumName.Text = "Album";
            lblArtist.Text = "Artist";
            picAlbumArt.Image = null;
        }


        private void searchCategorized()
        {
            string searchText = txtSearch.Text.ToLower();
            string searchType = cmbSearchType.SelectedItem.ToString();

            songListView.BeginUpdate();
            songListView.Items.Clear();
            var musicFiles = Directory.GetFiles(musicFolder, "*.mp3", SearchOption.AllDirectories);

            foreach (var file in musicFiles)
            {
                var fileInfo = TagLib.File.Create(file);
                string title = fileInfo.Tag.Title ?? Path.GetFileNameWithoutExtension(file);
                string artist = fileInfo.Tag.FirstPerformer ?? "Unknown Artist";
                string album = fileInfo.Tag.Album ?? "Unknown Album";

                bool match = false;
                switch (searchType)
                {
                    case "Title": match = title.ToLower().Contains(searchText); break;
                    case "Artist": match = artist.ToLower().Contains(searchText); break;
                    case "Album": match = album.ToLower().Contains(searchText); break;
                }
                bool isCurrentSong = file == currentSongPath;
                if (match || string.IsNullOrEmpty(searchText) || isCurrentSong)
                {
                    var item = new ListViewItem(title);
                    item.SubItems.Add(artist);
                    item.SubItems.Add(album);
                    item.SubItems.Add(fileInfo.Properties.Duration.ToString(@"mm\:ss"));
                    item.SubItems.Add(fileInfo.Tag.Year.ToString());
                    item.SubItems.Add(fileInfo.Tag.Track.ToString());
                    item.Tag = file;
                    songListView.Items.Add(item);

                    if (isCurrentSong)
                    {
                        item.Selected = true;
                        item.EnsureVisible();
                    }
                }
            }
            songListView.EndUpdate();
            lblTotalTracks.Text = songListView.Items.Count + " Tracks";
            UpdateTotalPlayTime();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text)) { searchCategorized(); }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //searchCategorized();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Clear();
                searchCategorized();
            }

        }
        private void UpdateTotalPlayTime()
        {
            TimeSpan totalDuration = TimeSpan.Zero;

            foreach (ListViewItem item in songListView.Items)
            {
                string filePath = item.Tag.ToString();

                try
                {
                    var fileInfo = TagLib.File.Create(filePath);
                    totalDuration += fileInfo.Properties.Duration;
                }
                catch
                {
                    continue;
                }
            }

            lblTotalPlayTime.Text = FormatLongDuration(totalDuration);
        }
        private string FormatLongDuration(TimeSpan duration)
        {
            return $"{(int)duration.TotalHours}:{duration:mm\\:ss}";
        }

        private void btnSyncCache_Click(object sender, EventArgs e)
        {
            GenerateMusicXmlCache();
        }

    }
    //public class Song
    //{
    //    public string Title { get; set; }
    //    public string Artist { get; set; }
    //    public string Album { get; set; }
    //    public string Duration { get; set; }
    //    public string Year { get; set; }
    //    public string Track { get; set; }
    //    public string Path { get; set; }
    //}

}