using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MusicPlayer.Classes
{
    class EmbeddedIcons
    {
	/// <summary>
	/// Class for loading all the icons and stuff.
	/// </summary>
	/// <returns>thumb as Icon</returns>

		public Icon thumbnailPlay()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resource = "MusicPlayer.thumbnailPlay.ico";

            Icon thumb = new Icon(assembly.GetManifestResourceStream(resource));
            return thumb;
        }

        public Icon thumbnailPause()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resource = "MusicPlayer.thumbnailPause.ico";

            Icon thumb = new Icon(assembly.GetManifestResourceStream(resource));
            return thumb;
        }
    }
}
