using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Artist;

namespace MusicPlayer.MusicModule.Views.Artist
{
    /// <summary>
    /// Interaction logic for ArtistListView.xaml
    /// </summary>
    public partial class ArtistListView : UserControl
    {
        public ArtistListView(ArtistListViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
