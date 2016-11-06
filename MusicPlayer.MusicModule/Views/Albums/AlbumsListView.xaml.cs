using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Albums;

namespace MusicPlayer.MusicModule.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumsListView.xaml
    /// </summary>
    public partial class AlbumsListView : UserControl
    {
        public AlbumsListView(AlbumsLitstViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
