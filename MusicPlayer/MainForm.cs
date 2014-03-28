using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mp3Lib;
using NAudio;
using NAudio.Wave;
using System.IO;
using System.Xml.Linq;
using MusicPlayer.Classes;
using System.Text.RegularExpressions;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Reflection;

namespace MusicPlayer
{
    public partial class MainForm : Form
    {
        #region Declaring all the types we'll need
        public bool isPlaying;
        public static string currentlyPlaying = null;
        public static string libraryLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic).ToString() + @"\MSINC_Library.xml";
        public string fileToTagEdit;
        public static IWavePlayer waveOutDevice;
        public static AudioFileReader audioFileReader;
        public long pausePosition = -1;
        Classes.TagHandling tg = new Classes.TagHandling();
        Classes.MediaControls mc = new Classes.MediaControls();
        notifyIcon_widget nf = new notifyIcon_widget();

        ThumbnailToolbarButton thumbPlayButton;
        #endregion
        
        //Old legacy stuff, keeping just because
        //private BlockAlignReductionStream stream = null;
        //private DirectSoundOut output = null;


        public MainForm()
        {
            try
            {
                CheckForIllegalCrossThreadCalls = false;
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal MusicPlayer.Classes.TagHandling TagHandling
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public TagEditor TagEditor
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            notifierIcon.Visible = true;
            
            //MessageBox.Show(Assembly.GetExecutingAssembly().GetManifestResourceNames().ToString());
            try
            {
                XDocument doc = XDocument.Load(libraryLocation);
                queryData(doc);
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("We could not find your Music Library anywhere!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            EmbeddedIcons ei = new EmbeddedIcons();
            thumbPlayButton = new ThumbnailToolbarButton(ei.thumbnailPlay(), "Play/Pause");
            thumbPlayButton.Click += thumbPlayButton_Click;
            popPlayListView();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            
            thumbPlayButton.Visible = true;
            thumbPlayButton.Enabled = true;
            // = new ThumbnailToolbarButton(null, MediaControls.playPause);
        }

        private void thumbPlayButton_Click(object sender, ThumbnailButtonClickedEventArgs e)
        {
            mc.pausePlayBack();
            thumbPlayButton.Tooltip = MediaControls.playPause;
        }

        public void queryData(XDocument doc)
        {
            
            var data = from item in doc.Descendants("Tracks")
                       select new
                       {
                           Artist = item.Element("Artist").Value,
                           Title = item.Element("Title").Value,
                           Album = item.Element("Album").Value,
                           Genre = item.Element("Genre").Value,
                           Year = item.Element("Year").Value,
                           FileName = item.Element("FileName").Value
                       };
            ListViewItem lvi = new ListViewItem();
            MainForm mf = new MainForm();
            foreach(var info in data)
            {
                lvi = new ListViewItem();

                lvi.Text = info.Artist.ToString();
                lvi.SubItems.Add(info.Album.ToString());
                lvi.SubItems.Add(info.Title.ToString());
                lvi.SubItems.Add(info.Genre.ToString());
                lvi.SubItems.Add(info.FileName.ToString());


                this.listView1.Items.Add(lvi);
                
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "MP3 Files (*.mp3) | *.mp3";
            if (of.ShowDialog() != DialogResult.OK) return;
            
            mc.disposeWave();
            timerSong.Dispose();
            //WaveStream pcm = WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(of.FileName));
            //stream = new BlockAlignReductionStream(pcm);
            //output = new DirectSoundOut();
            //output.Init(stream);
            timerSong.Start();
            //output.Play();

            audioFileReader = new AudioFileReader(of.FileName);
            waveOutDevice = new WaveOut();
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();

            currentlyPlaying = of.FileName.ToString();
            updateLabelsArt();
            playButton.Enabled = true;
            button1.Enabled = true;
            /*string artistString;
            string albumString;
            string titleString;
            string year;
            string length;
            try
            {
                Mp3File file = new Mp3File(@"C:\Users\Mike\Desktop\artifacts.mp3");
                artistString = file.TagHandler.Artist.ToString();
                albumString = file.TagHandler.Album.ToString();
                titleString = file.TagHandler.Title.ToString();
                year = file.TagHandler.Year.ToString();
                length = file.TagHandler.Length.ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = artistString;
                lvi.SubItems.Add(albumString);
                lvi.SubItems.Add(titleString);
                lvi.SubItems.Add(year);
                lvi.SubItems.Add(@"C:\Users\Mike\Desktop\artifacts.mp3");

                listView1.Items.Add(lvi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            mc.pausePlayBack();
            playButton.Text = MediaControls.playPause.ToString();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            else if(e.CloseReason == CloseReason.WindowsShutDown)
            {
                notifierIcon.Visible = false;
                Application.Exit();
            }
        }

        public void populateListView()
        {
            
            string artistTitle = null;
            string albumTitle = null;
            string songTitle = null;
            string genre = null;
            string fileNameConverted = null;
            
                DirectoryInfo dinfo = new DirectoryInfo(@"C:\Users\Mike\Music\");
                FileInfo[] Files = dinfo.GetFiles("*.mp3", SearchOption.AllDirectories);
                
                ListViewItem lvi = new ListViewItem();

                foreach (FileInfo file in Files)
                {
                    string s = file.Name.ToString();
                    char[] arr = s.ToCharArray();

                    fileNameConverted = file.FullName.ToString();

                    try
                    {
                        artistTitle = tg.getArtistTitle(fileNameConverted.ToString()).ToString();

                        albumTitle = tg.getAlbumTitle(fileNameConverted.ToString()).ToString();

                        songTitle = tg.getSongTitle(fileNameConverted.ToString()).ToString();

                        genre = tg.getGenreString(fileNameConverted.ToString()).ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.Message + "when trying to get " + fileNameConverted);
                    }

                    
                    
                    lvi = new ListViewItem();

                    lvi.Text = artistTitle;
                    lvi.SubItems.Add(albumTitle);
                    lvi.SubItems.Add(songTitle);
                    lvi.SubItems.Add(genre);
                    lvi.SubItems.Add(fileNameConverted);
                    

                    this.listView1.Items.Add(lvi);
                }
            
            
        }

        public void updateLabelsArt()
        {
            
            if (tg.getSongTitle(currentlyPlaying).ToString() != null)
            {
                //nowPlaying_songTitle.Text = tg.getSongTitle(currentlyPlaying).ToString();
                songTitleLabel.Text = tg.getSongTitle(currentlyPlaying).ToString();
            }
            else
            {
                songTitleLabel.Text = currentlyPlaying.ToString();
                //nowPlaying_songTitle.Text = currentlyPlaying.ToString();
            }

            if (tg.getArtistTitle(currentlyPlaying).ToString() != null)
            {
                //nowPlaying_artistTitle.Text = tg.getArtistTitle(currentlyPlaying).ToString();
                artistPlayingLabel.Text = tg.getArtistTitle(currentlyPlaying).ToString();
            }
            else
            {
                //nowPlaying_artistTitle.Text = "Unknown Artist";
                artistPlayingLabel.Text = "Unknown Artist";
            }

            if (tg.getAlbumTitle(currentlyPlaying).ToString() != null)
            {
                //nowPlaying_albumTitle.Text = tg.getAlbumTitle(currentlyPlaying).ToString();
                albumTitleLabel.Text = tg.getAlbumTitle(currentlyPlaying).ToString();
            }
            else
            {
                //nowPlaying_albumTitle.Text = "Unknown Album";
                albumTitleLabel.Text = "Unknown Album";
            }

            if (tg.getAlbumArt(currentlyPlaying) != null)
            {
                albumArt.BackgroundImage = tg.getAlbumArt(currentlyPlaying);
                //nowPlaying_albumArt.BackgroundImage = tg.getAlbumArt(currentlyPlaying);
            }

            this.Text = currentlyPlaying.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            populate_bw.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            populateListView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(createLibrary().ToString());
            MainForm mf = new MainForm();
            TagHandling tg = new TagHandling();
            XElement rootElement = new XElement("MusicLibrary");
            foreach (ListViewItem lvi in listView1.Items)
            {

                string artist = lvi.Text;
                string album = lvi.SubItems[1].Text.ToString();
                string songTitle = lvi.SubItems[2].Text.ToString();
                string genre = lvi.SubItems[3].Text.ToString();
                string fileName = lvi.SubItems[4].Text.ToString();
                string year;



                try
                {
                    year = tg.getYearString(fileName).ToString();
                }
                catch (NullReferenceException nx)
                {
                    Console.WriteLine("Ignoring NullReferenceException " + nx.Message);
                    year = "0000";
                }
                rootElement.Add(
                    new XElement("Tracks",
                        new XElement("Title", songTitle),
                        new XElement("Artist", artist),
                        new XElement("Album", album),
                        new XElement("Genre", genre),
                        new XElement("Year", year),
                        new XElement("FileName", fileName)
                ));
            }
            XDocument MusicLibrary = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), new XComment("Generated on " + DateTime.Now.ToString()), rootElement);
            //Console.WriteLine(MusicLibrary.ToString());
            try
            {
                string whereToSave = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic).ToString() + @"\MSINC_Library.xml";
                MusicLibrary.Save(whereToSave);
                MessageBox.Show("Saved!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (MediaControls.waveOutDevice != null && MediaControls.audioFileReader != null)
            {
                TimeSpan currentTime = (MediaControls.waveOutDevice.PlaybackState == PlaybackState.Stopped) ? TimeSpan.Zero : MediaControls.audioFileReader.CurrentTime;
                trackBar.Value = Math.Min(trackBar.Maximum, (int)(100 * currentTime.TotalSeconds / MediaControls.audioFileReader.TotalTime.TotalSeconds));
                labelCurTime.Text = String.Format("{0:00}:{1:00}", (int)currentTime.TotalMinutes,
                    currentTime.Seconds);
                
            }
            else
            {
                trackBar.Value = 0;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            MediaControls mc = new MediaControls();
            if (listView1.SelectedItems.Count > 0)
            {
                string fileToPlay;
                fileToPlay = listView1.SelectedItems[0].SubItems[4].Text;
                mc.disposeWave();
                //Timer
                System.Timers.Timer songTimer = new System.Timers.Timer(500);
                songTimer.Enabled = true;
                songTimer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Tick);
                songTimer.Start();
                //
                //timerSong.Start();
                currentlyPlaying = fileToPlay.ToString();
                updateLabelsArt();
                playButton.Enabled = true;
                playButton.Text = "Pause";
                nf.button1.Text = "Pause";
                button1.Enabled = true;
                //
                notifierIcon.ShowBalloonTip(5000, "Now Playing", songTitleLabel.Text + " by " + artistPlayingLabel.Text, ToolTipIcon.Info);
                //
                audioFileReader = new AudioFileReader(currentlyPlaying);
                mc.beginPlayback(currentlyPlaying);
                labelTotalTime.Text = String.Format("{0:00}:{1:00}", (int)MediaControls.audioFileReader.TotalTime.TotalMinutes, audioFileReader.TotalTime.Seconds);
                //
                
                checkPlayListCheck();
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (MediaControls.waveOutDevice != null)
            {
                MediaControls.audioFileReader.CurrentTime = TimeSpan.FromSeconds(MediaControls.audioFileReader.TotalTime.TotalSeconds * trackBar.Value / 100.0);
            }
        }

        private void editTagsForTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                TagEditor tagEdit = new TagEditor(listView1.SelectedItems[0].SubItems[4].Text);
                tagEdit.ShowDialog();
            }

            
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer
            // object.
            this.listView1.ListViewItemSorter = new ListViewItemComparer(e.Column);
            // Call the sort method to manually sort.
            listView1.Sort();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifierIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.Visible == false)
            {
                this.Show();
            }
        }

        private void notifierIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentlyPlaying == null)
            {
            }
            else
            {
                notifyIcon_widget widget = new notifyIcon_widget();
                widget.Show();
            }
            
        }

        public void popPlayListView()
        {
            foreach(ListViewItem lvi in listView1.Items)
            {
                string songTitle;
                string fileName;
                //This will be added to the second one
                ListViewItem ivl = new ListViewItem();

                songTitle = lvi.SubItems[2].Text;
                fileName = lvi.SubItems[4].Text;

                ivl.Text = songTitle;
                ivl.SubItems.Add(fileName);
                playListView.Items.Add(ivl);
                if (currentlyPlaying != null)
                {
                    if(currentlyPlaying == fileName)
                    {
                        ivl.Checked = true;
                    }
                }
            }
        }

        public void playNextSong()
        {
            string fileName;
            foreach (ListViewItem lvi in playListView.Items)
            {
                fileName = lvi.SubItems[1].Text;
                if (lvi.Checked == true)
                {
                    int finIndex;
                    lvi.Checked = false;
                    finIndex = lvi.Index;
                    finIndex++;
                    if (finIndex < playListView.Items.Count)
                    {
                        var nextGuy = playListView.Items[finIndex];
                        nextGuy.Checked = true;
                        string fileToPlay = nextGuy.SubItems[1].Text;
                        //currentlyPlaying = fileToPlay();
                        mc.beginPlayback(fileToPlay);
                    }

                }
            }
            checkPlayListCheck();
            updateLabelsArt();
        }

        public void checkPlayListCheck()
        {
            foreach(ListViewItem lvi in playListView.Items)
            {
                string fileName;
                fileName = lvi.SubItems[1].Text;
                if(currentlyPlaying != null)
                {
                    if(currentlyPlaying == fileName)
                    {
                        lvi.Checked = true;
                    }
                    else
                    {
                        //lvi.Remove();
                        lvi.Checked = false;
                    }
                }
                else
                {
                    //lvi.Remove();
                    lvi.Checked = false;
                }

            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            mc.disposeWave();
            Application.Exit();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    Point pt = e.Location;
                    listViewContext.Show(listView1, pt);
                }
            }
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            playNextSong();
        }

    }
}
