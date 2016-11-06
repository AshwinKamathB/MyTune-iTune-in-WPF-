using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Genres;

namespace MusicPlayer.MusicModule.Views.Genres
{
    /// <summary>
    /// Interaction logic for GenresView.xaml
    /// </summary>
    public partial class GenresView : UserControl
    {
        public GenresView(GenresViewViewModel viewModel)
        {
            InitializeComponent();

            this.DataContext = viewModel;
        }
    }
}
