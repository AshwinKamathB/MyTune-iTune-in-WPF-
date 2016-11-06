
using System;
using System.Linq;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using MusicPlayer.MusicModule.Events;
using MusicPlayer.MusicModule.Services;

namespace MusicPlayer.MusicModule.ViewModels.Artist
{
    public class ArtistDetailsViewModel : ViewModelBase
    {
        private IEventAggregator eventAggregator;

        private IMusicDataService dataService;

        private Model.Albums albums;

        private IRegionManager regionManager;

        private ArtistSummaryModel artistSummaryModel;

        public ArtistDetailsViewModel(IRegionManager regionManager, IEventAggregator eventAggregator, IMusicDataService dataService)
        {

            if (dataService == null) throw new ArgumentNullException("dataService");
            if (eventAggregator == null) throw new ArgumentNullException("eventAggregator");

            this.dataService = dataService;
            this.eventAggregator = eventAggregator;
            this.regionManager = regionManager;

            this.eventAggregator = eventAggregator;
            this.eventAggregator.GetEvent<ArtistSelectedEvent>().Subscribe(this.ArtistSelected, true);
        }

        public Model.Albums Albumses
        {
            get { return albums; }
            set
            {
                albums = value;
                OnPropertyChanged("Albumses");
            }
        }

        public ArtistSummaryModel ArtistSummaryModel
        {
            get { return artistSummaryModel; }
            set
            {
                artistSummaryModel = value;
                OnPropertyChanged("ArtistSummaryModel");
            }
        }

        private void ArtistSelected(int id)
        {
            // Get the employee entity with the selected ID.
            var albums = this.dataService.GetAlbums().Where(x => x.Artist.ArtistId == id).ToList();

            var artistSummaryModel = new ArtistSummaryModel
            {
                AlbumCount = albums.Count,
                SongsCount = albums.Sum(o => o.SongsCount)
            };
            if (albums.FirstOrDefault() != null)
            {
                var firstOrDefault = albums.FirstOrDefault();
                artistSummaryModel.ArtistName = firstOrDefault.Artist.Name;
            }

            Albumses=new Model.Albums();

            foreach (var alb in albums)
            {
                Albumses.Add(alb);
            }

            ArtistSummaryModel = artistSummaryModel;
        }
    }
}
