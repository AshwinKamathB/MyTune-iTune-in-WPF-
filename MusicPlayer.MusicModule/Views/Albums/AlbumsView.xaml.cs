using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Albums;

namespace MusicPlayer.MusicModule.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumsView.xaml
    /// </summary>
    public partial class AlbumsView : UserControl
    {
        public AlbumsView(AlbumsViewViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
