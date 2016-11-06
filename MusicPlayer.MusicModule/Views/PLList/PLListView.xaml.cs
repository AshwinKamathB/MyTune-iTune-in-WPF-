using System.Windows.Controls;
using MusicPlayer.MusicModule.ViewModels.PLList;

namespace MusicPlayer.MusicModule.Views.PLList
{
    /// <summary>
    /// Interaction logic for PLListView.xaml
    /// </summary>
    public partial class PLListView : UserControl
    {
        public PLListView(PlayListViewViewModel playlistViewModel)
        {
            InitializeComponent();
            this.DataContext = playlistViewModel;
        }
    }
}
