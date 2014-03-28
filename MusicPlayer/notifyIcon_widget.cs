using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MusicPlayer.Classes;

namespace MusicPlayer
{
    public partial class notifyIcon_widget : Form
    {
        public notifyIcon_widget()
        {
            InitializeComponent();
        }

        private void notifyIcon_widget_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void notifyIcon_widget_Load(object sender, EventArgs e)
        {
            TagHandling tg = new TagHandling();
            //
            button1.Text = MediaControls.playPause;
            //Get the song info and stuff
            songTitleLabel.Text = tg.getSongTitle(MainForm.currentlyPlaying).ToString();
            label1.Text = tg.getArtistTitle(MainForm.currentlyPlaying).ToString();
            //
            this.BackgroundImage = tg.getAlbumArt(MainForm.currentlyPlaying);
        }
        protected override void OnLoad(EventArgs e)
        {
            PlaceLowerRight();
            base.OnLoad(e);
        }

        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            Screen screen = Screen.PrimaryScreen;
            
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MediaControls mc = new MediaControls();
            mc.pausePlayBack();
            button1.Text = MediaControls.playPause;
        }

        private void updatePlayPause_Tick(object sender, EventArgs e)
        {
            button1.Text = MediaControls.playPause;
        }
    }
}
