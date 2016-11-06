using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Artist;

namespace MusicPlayer.MusicModule.Views.Artist
{
    /// <summary>
    /// Interaction logic for ArtistView.xaml
    /// </summary>
    public partial class ArtistView : UserControl
    {
        public ArtistView(ArtistViewViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
