using System;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;
using MusicPlayer.MusicModule.Model;

namespace MusicPlayer.MusicModule.ViewModels
{
    public class MusicDetailsViewModel : ViewModelBase
    {
        private int selectedIndex;
        public ObservableCollection<EntertaimentItem> EntertaimentTypes { get; set; }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                selectedIndex = value;
                OnPropertyChanged("SelectedIndex");
            }
        }

        public MusicDetailsViewModel()
        {
            this.SelectedIndex = 2;
            this.EntertaimentTypes = new ObservableCollection<EntertaimentItem>
            {
                new EntertaimentItem()
                {
                    Icon = new BitmapImage(new Uri(@"pack://application:,,,/Images/music.png")),
                    Name = "Music"
                },
                new EntertaimentItem()
                {
                    Icon = new BitmapImage(new Uri(@"pack://application:,,,/Images/movie.png")),
                    Name = "Movies"
                },
                 new EntertaimentItem()
                {
                    Icon = new BitmapImage(new Uri(@"pack://application:,,,/Images/app_store.png")),
                    Name = "Apps"
                }
                
            };
        }
    }
}