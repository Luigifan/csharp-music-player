using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MusicPlayer.Classes
{
    class MusicLibrary
    {
        public string artist { get; private set; }
        public string album { get; private set; }
        public string song { get; private set; }
        public string genre { get; private set; }
        public string fileLocation { get; private set; }

        public MusicLibrary(string Artist, string Album, string Song, string Genre, string FileLocation)
        {
            artist = Artist;
            album = Album;
            song = Song;
            genre = Genre;
            fileLocation = FileLocation;
        }

        public override string ToString()
        {
            return artist;
        }

        public void writeXml()
        {
            
            
            //saveFinalXml(doc);
                
        }
        public void saveFinalXml(XDocument finalDoc)
        {
            finalDoc.Save("Library.xml");
        }
    }
}
