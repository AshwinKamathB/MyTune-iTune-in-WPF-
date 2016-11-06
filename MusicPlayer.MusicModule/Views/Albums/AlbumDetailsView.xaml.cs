using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Albums;

namespace MusicPlayer.MusicModule.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumDetailsView.xaml
    /// </summary>
    public partial class AlbumDetailsView : UserControl
    {
        public AlbumDetailsView(AlbumDetailsViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
