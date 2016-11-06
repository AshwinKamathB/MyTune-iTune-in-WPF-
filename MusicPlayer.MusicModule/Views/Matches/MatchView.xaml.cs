using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.Matches;

namespace MusicPlayer.MusicModule.Views.Matches
{
    /// <summary>
    /// Interaction logic for MatchView.xaml
    /// </summary>
    public partial class MatchView : UserControl
    {
        public MatchView(MatchesViewViewModel viewModel)
        {
            InitializeComponent();
            this.DataContext = viewModel;
        }
    }
}
