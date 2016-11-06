using System.Windows.Media.Imaging;

namespace MusicPlayer.MusicModule.Model
{
    public class Artist
    {
        public int ArtistId { get; set; }

        public string Name { get; set; }

        public BitmapImage Image { get; set; }
    }
}
