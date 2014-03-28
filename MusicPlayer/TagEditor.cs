using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mp3Lib;
using System.Security.Permissions;
using System.IO;
using MusicPlayer.Classes;

namespace MusicPlayer
{
    public partial class TagEditor : Form
    {
        Classes.TagHandling tg = new Classes.TagHandling();
        MainForm mf = new MainForm();
        MediaControls mc = new MediaControls();

        public TagEditor(string fileToTagEdit)
        {
            InitializeComponent();

            loadFromFile(fileToTagEdit);
        }

        private void TagEditor_Load(object sender, EventArgs e)
        {
            
        }

        public void loadFromFile(string fileName)
        {
            try
            {
                filePathTextBox.Text = fileName.ToString();

                //load the objects into their respective forms
                trackTitleTextBox.Text = songTitle(fileName).ToString();
                artistTextBox.Text = artist(fileName).ToString();
                albumTextBox.Text = album(fileName).ToString();
                genreTextBox.Text = genre(fileName).ToString();
                yearTextBox.Text = year(fileName).ToString();
                trackNumberTextBox.Text = track(fileName).ToString();
                artPictureBox.BackgroundImage = albumArt(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error loading from file\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        #region Objects to Load
        object songTitle(string file)
        {
            return tg.getSongTitle(file).ToString();
        }
        object artist(string file)
        {
            return tg.getArtistTitle(file).ToString();
        }
        object album(string file)
        {
            return tg.getAlbumTitle(file).ToString();
        }
        Image albumArt(string file)
        {
            return tg.getAlbumArt(file);
        }
        object genre(string file)
        {
            return tg.getGenreString(file);
        }
        object year(string file)
        {
            return tg.getYearString(file);
        }
        object track(string file)
        {
            return tg.getTrackString(file).ToString();
        }
        #endregion

        public static bool ValidateInput(KeyPressEventArgs e)
        {
            bool blDiscardUserInput = true;

            //A-Z
            if (e.KeyChar >= 60 && e.KeyChar <= 90)
                blDiscardUserInput = true;

            // a-z
            if (e.KeyChar >= 97 && e.KeyChar <= 122)
                blDiscardUserInput = true;

            // 0-9
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                blDiscardUserInput = false;

            // Backspace
            if (e.KeyChar == 8)
                blDiscardUserInput = false;

            // Comma
            if (e.KeyChar == 44)
                blDiscardUserInput = true;

            // Single Quote
            if (e.KeyChar == 39)
                blDiscardUserInput = true;

            // Space
            if (e.KeyChar == 32)
                blDiscardUserInput = true;

            // Hyphen
            if (e.KeyChar == 45)
                blDiscardUserInput = true;

            // Dot
            if (e.KeyChar == 46)
                blDiscardUserInput = true;

            // Enter
            if (e.KeyChar == 13)
                blDiscardUserInput = true;

            return blDiscardUserInput;
        }

        private void yearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateInput(e);
        }

        private void trackNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = ValidateInput(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Image Files(*.jpg, *.jpeg, *.png, *.bmp|*.jpg;*.jpeg;*.png*.bmp|Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpeg;*.jpg|PNG Files (*.png)|*.png|All files(*.*)|*.*";
            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string artLoc = of.FileName;
                    Image art = Image.FromFile(artLoc);
                    artPictureBox.BackgroundImage = art;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Error when trying to load album art\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Mp3File file = new Mp3File(filePathTextBox.Text);
                //Checks to see if the track we wanna edit is being read by the music player
            try
            {
                if (MainForm.currentlyPlaying.ToString() == null)
                {

                }
                else
                {
                    if (MainForm.currentlyPlaying.ToString() == filePathTextBox.Text)
                    {
                        mc.disposeWave();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //Writes the actual track info
            if (trackTitleTextBox.Text != null)
            {
                file.TagHandler.Title = trackTitleTextBox.Text.ToString();
            }
            if (artistTextBox.Text != null)
            {
                file.TagHandler.Artist = artistTextBox.Text.ToString();
            }
            if (albumTextBox.Text != null)
            {
                file.TagHandler.Album = albumTextBox.Text.ToString();
            }
            if (genreTextBox.Text != null)
            {
                file.TagHandler.Genre = genreTextBox.Text.ToString();
            }
            if (trackNumberTextBox.Text != null)
            {
                file.TagHandler.Track = trackNumberTextBox.Text.ToString();
            }
            if (yearTextBox.Text != null)
            {
                file.TagHandler.Year = yearTextBox.Text.ToString();
            }
            if (pictureBox1.BackgroundImage != null)
            {
                file.TagHandler.Picture = artPictureBox.BackgroundImage;
            }


            //Actual saving method, tries/catches to make sure the files not read only
            try
            {
                file.Update();
                MessageBox.Show("Tags saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (UnauthorizedAccessException ex)
            {
                //This exception should only happen if the File is readonly
                DialogResult result = MessageBox.Show(this, "Couldn't open the file for write, try to disable read-only?\n" + ex.Message, "Error!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        FileInfo fileInfo = new FileInfo(filePathTextBox.Text);
                        fileInfo.IsReadOnly = false;
                        file.Update();
                        MessageBox.Show("Tags saved successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Couldn't disable read only!\n" + exc.Message);
                    }
                }
                if (result == DialogResult.No)
                {
                    MessageBox.Show("Tags will not be saved");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Error! \n" + ex.Message);
            }
            
        }

    }

}
