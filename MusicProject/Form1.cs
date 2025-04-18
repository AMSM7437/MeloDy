using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
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
        private string defaultMusicPathConfig = @"C:\musicPath\musicPath.config";




        public Form1()
        {
            InitializeComponent();

            SetupPlayer();
        }
        private void InitializeMusicFolder()
        {


            if (File.Exists(defaultMusicPathConfig))
            {
                string directory = File.ReadAllText(defaultMusicPathConfig);
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
            using (var folderDialog = new FolderBrowserDialog())
            {

                folderDialog.Description = "Please select the music path";
                folderDialog.ShowNewFolderButton = false;
                folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolder = folderDialog.SelectedPath;
                    if (Directory.Exists(selectedFolder))
                    {
                        musicFolder = selectedFolder;
                        File.WriteAllText(defaultMusicPathConfig, musicFolder);
                        cleanupSong();
                        LoadMusic();
                    }
                    else
                    {
                        changeMusicPath();
                    }
                }
                else
                {
                    MessageBox.Show("No folder selected - using default");
                    cleanupSong();
                    LoadMusic();
                }
            }
        }
        private void SetupPlayer()
        {

            progressTimer = new Timer { Interval = 200 };
            progressTimer.Tick += ProgressTimer_Tick;

            if (songListView.Columns.Count == 0)
            {
                songListView.Columns.Add("Title", 300, HorizontalAlignment.Left);
                songListView.Columns.Add("Duration", 100, HorizontalAlignment.Right);
                songListView.Columns.Add("Album", 150, HorizontalAlignment.Left);
                //songListView.Columns.Add("Duration", 80, HorizontalAlignment.Right);
                songListView.Columns.Add("Year", 60, HorizontalAlignment.Right);
                songListView.Columns.Add("Track", 60, HorizontalAlignment.Right);
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
            try
            {
                songListView.Items.Clear();
                var musicFiles = Directory.GetFiles(musicFolder, "*.mp3");

                foreach (var file in musicFiles)
                {
                    var fileInfo = TagLib.File.Create(file);
                    var item = new ListViewItem(fileInfo.Tag.Title ?? Path.GetFileNameWithoutExtension(file));

                    item.SubItems.Add(fileInfo.Tag.FirstPerformer ?? "Unknown Artist");
                    item.SubItems.Add(fileInfo.Tag.Album ?? "Unknown Album");
                    item.SubItems.Add(fileInfo.Properties.Duration.ToString(@"mm\:ss"));
                    item.SubItems.Add(fileInfo.Tag.Year.ToString());
                    item.SubItems.Add(fileInfo.Tag.Track.ToString());

                    item.Tag = file;
                    songListView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading music: {ex.Message}");
            }
        }

        private void UpdateNowPlaying(string filePath)
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
            if (songListView.SelectedItems.Count == 0) return;

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
                    nextIndex = 0;
            }

            songListView.Items[nextIndex].Selected = true;
            PlaySong(songListView.Items[nextIndex].Tag.ToString());
        }

        private void PlayPreviousSong()
        {
            if (songListView.Items.Count == 0) return;

            int prevIndex = 0;
            if (songListView.SelectedItems.Count > 0)
            {
                prevIndex = songListView.SelectedIndices[0] - 1;
                if (prevIndex < 0)
                    prevIndex = songListView.Items.Count - 1;
            }

            songListView.Items[prevIndex].Selected = true;
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

        private void songListView_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //test
        }
    }
}