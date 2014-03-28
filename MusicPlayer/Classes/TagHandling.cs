using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mp3Lib;
using System.Windows.Forms;
using System.Drawing;

namespace MusicPlayer.Classes
{
    class TagHandling
    {
        public void getTags(string fileName)
        {
            string artistString;
            string albumString;
            string titleString;
            string year;
            string fileNameString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                artistString = file.TagHandler.Artist.ToString();
                albumString = file.TagHandler.Album.ToString();
                titleString = file.TagHandler.Title.ToString();
                year = file.TagHandler.Year.ToString();
                fileNameString = fileName;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getSongTitle(string fileName)
        {
            string songTitleString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                songTitleString = file.TagHandler.Title.ToString();
                return songTitleString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string getArtistTitle(string fileName)
        {
            string artistString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                artistString = file.TagHandler.Artist.ToString();
                return artistString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string getAlbumTitle(string fileName)
        {
            string albumString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                albumString = file.TagHandler.Album.ToString();
                return albumString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string getYearString(string fileName)
        {
            string yearString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                yearString = file.TagHandler.Year;
                return yearString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string getGenreString(string fileName)
        {
            string genreString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                genreString = file.TagHandler.Genre;
                return genreString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Bitmap getAlbumArt(string fileName)
        {
            try
            {
                Mp3File file = new Mp3File(fileName);
                Bitmap art = (Bitmap)file.TagHandler.Picture;
                return art;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public string getTrackString(string fileName)
        {
            string trackString;
            try
            {
                Mp3File file = new Mp3File(fileName);
                trackString = file.TagHandler.Track.ToString();
                return trackString;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
