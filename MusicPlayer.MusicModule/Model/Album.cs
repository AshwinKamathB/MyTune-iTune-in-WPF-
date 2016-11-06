using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace MusicPlayer.MusicModule.Model
{
    public class Album
    {
        public Artist Artist { get; set; }
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public BitmapImage AlbumArtUrl { get; set; }
        public string ReleaseYear { get; set; }
        public List<Song> Songs { get; set; }
        public string Length { get; set; }
        public int Id { get; set; }

        public int SongsCount
        {
            get { return Songs.Count; }
        }

    }
}
