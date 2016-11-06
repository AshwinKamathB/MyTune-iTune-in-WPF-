using System;
using Microsoft.Practices.Prism.PubSubEvents;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using MusicPlayer.MusicModule.Events;
using MusicPlayer.MusicModule.Services;
using MusicPlayer.MusicModule.Views.Albums;

namespace MusicPlayer.MusicModule
{
    public class MainRegionController
    {
        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;
        private readonly IEventAggregator eventAggregator;
        private readonly IMusicDataService dataService;


        public MainRegionController(IUnityContainer container,
                                    IRegionManager regionManager,
                                    IEventAggregator eventAggregator,
                                    IMusicDataService dataService)
        {
            if (container == null) throw new ArgumentNullException("container");
            if (regionManager == null) throw new ArgumentNullException("regionManager");
            if (eventAggregator == null) throw new ArgumentNullException("eventAggregator");
            if (dataService == null) throw new ArgumentNullException("dataService");

            this.container = container;
            this.regionManager = regionManager;
            this.eventAggregator = eventAggregator;
            this.dataService = dataService;

            // Subscribe to the EmployeeSelectedEvent event.
            // This event is fired whenever the user selects an
            // employee in the EmployeeListView.
            //this.eventAggregator.GetEvent<AlbumSelectedEvent>().Subscribe(this.AlbumSelected, true);
        }

        private void AlbumSelected(int obj)
        {
            IRegion mainRegion = this.regionManager.Regions[RegionNames.AlbumRightRegion];
            if (mainRegion == null) return;


            // Check to see if we need to create an instance of the view.
            var view = mainRegion.GetView("AlbumDetailsView") as AlbumDetailsView;
            if (view == null)
            {
                // Create a new instance of the EmployeeDetailsView using the Unity container.
                view = this.container.Resolve<AlbumDetailsView>();

                // Add the view to the main region. This automatically activates the view too.
                mainRegion.Add(view, "AlbumDetailsView");
            }
            else
            {
                // The view has already been added to the region so just activate it.
                mainRegion.Activate(view);
            }
        }
    }
}