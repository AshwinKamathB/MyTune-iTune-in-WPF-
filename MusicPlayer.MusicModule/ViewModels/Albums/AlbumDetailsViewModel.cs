using System;
using System.Linq;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using MusicPlayer.MusicModule.Events;
using MusicPlayer.MusicModule.Model;
using MusicPlayer.MusicModule.Services;
using MusicPlayer.MusicModule.Views.Albums;

namespace MusicPlayer.MusicModule.ViewModels.Albums
{
    public class AlbumDetailsViewModel : ViewModelBase
    {
        private IEventAggregator eventAggregator;

        private IMusicDataService dataService;

        private Album album;
        private IRegionManager regionManager;

        public AlbumDetailsViewModel(IRegionManager regionManager, IEventAggregator eventAggregator, IMusicDataService dataService)
        {

            if (dataService == null) throw new ArgumentNullException("dataService");
            if (eventAggregator == null) throw new ArgumentNullException("eventAggregator");

            this.dataService = dataService;
            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;

            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<AlbumSelectedEvent>().Subscribe(this.AlbumSelected, true);
        }

        public Album Album
        {
            get { return album; }
            set
            {
                album = value;
                OnPropertyChanged("Album");
            }
        }

        private void AlbumSelected(int id)
        {
            // Get the employee entity with the selected ID.
            Album = this.dataService.GetAlbums().FirstOrDefault(item => item.Id == id);

            
        }
    }
}
