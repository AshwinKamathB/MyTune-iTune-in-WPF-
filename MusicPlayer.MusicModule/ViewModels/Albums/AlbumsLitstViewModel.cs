using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Microsoft.Practices.Prism.PubSubEvents;
using MusicPlayer.MusicModule.Events;
using MusicPlayer.MusicModule.Model;
using MusicPlayer.MusicModule.Services;

namespace MusicPlayer.MusicModule.ViewModels.Albums
{
    public class AlbumsLitstViewModel : ViewModelBase
    {
        private IEventAggregator eventAggregator;

        private IMusicDataService dataService;

        public ICollectionView Albums { get; private set; }
        
        public AlbumsLitstViewModel(IMusicDataService dataService, IEventAggregator eventAggregator)
        {
            if (dataService == null) throw new ArgumentNullException("dataService");
            if (eventAggregator == null) throw new ArgumentNullException("eventAggregator");

            this.dataService = dataService;
            this.eventAggregator = eventAggregator;

            this.Albums = new ListCollectionView(dataService.GetAlbums());
            this.Albums.CurrentChanged += new EventHandler(this.SelectedAlbumChanged);
        }

        private void SelectedAlbumChanged(object sender, EventArgs e)
        {
            var album = this.Albums.CurrentItem as Album;
            if (album != null)
            {
                this.eventAggregator.GetEvent<AlbumSelectedEvent>().Publish(album.Id);
            }
        }
    }
}
