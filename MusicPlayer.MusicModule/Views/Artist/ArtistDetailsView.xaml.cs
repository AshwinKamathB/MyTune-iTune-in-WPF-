using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Artist;

namespace MusicPlayer.MusicModule.Views.Artist
{
    /// <summary>
    /// Interaction logic for ArtistDetailsView.xaml
    /// </summary>
    public partial class ArtistDetailsView : UserControl
    {
        public ArtistDetailsView(ArtistDetailsViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
