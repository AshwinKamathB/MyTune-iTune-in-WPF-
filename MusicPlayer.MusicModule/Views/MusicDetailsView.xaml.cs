using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels;

namespace MusicPlayer.MusicModule.Views
{
    /// <summary>
    /// Interaction logic for MusicDetailsView.xaml
    /// </summary>
    public partial class MusicDetailsView : UserControl
    {
        public MusicDetailsView(MusicDetailsViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
