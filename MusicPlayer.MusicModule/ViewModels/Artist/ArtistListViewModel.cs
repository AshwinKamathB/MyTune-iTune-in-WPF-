
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.PubSubEvents;
using MusicPlayer.MusicModule.Events;
using MusicPlayer.MusicModule.Services;

namespace MusicPlayer.MusicModule.ViewModels.Artist
{
    public class ArtistListViewModel : ViewModelBase
    {
        private IEventAggregator eventAggregator;

        private IMusicDataService dataService;

        public ICollectionView Artists { get; private set; }

        public ArtistListViewModel(IMusicDataService dataService, IEventAggregator eventAggregator)
        {
            if (dataService == null) throw new ArgumentNullException("dataService");
            if (eventAggregator == null) throw new ArgumentNullException("eventAggregator");

            this.dataService = dataService;
            this.eventAggregator = eventAggregator;

            var item = dataService.GetAlbums().Select(x => x.Artist).Distinct();
            var distintc= item.GroupBy(x => x.ArtistId).Select(x => x.First());

            this.Artists = new ListCollectionView(new ObservableCollection<Model.Artist>().AddRange(distintc.ToList()));
            this.Artists.CurrentChanged += new EventHandler(this.SelectedArtistChanged);
        }

        private void SelectedArtistChanged(object sender, EventArgs e)
        {
            var artist = this.Artists.CurrentItem as Model.Artist;
            if (artist != null)
            {
                this.eventAggregator.GetEvent<ArtistSelectedEvent>().Publish(artist.ArtistId);
            }
        }
    }
}
