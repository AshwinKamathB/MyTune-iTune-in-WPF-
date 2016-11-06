using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using MusicPlayer.MusicModule.Services;
using MusicPlayer.MusicModule.Views;
using MusicPlayer.MusicModule.Views.Albums;
using MusicPlayer.MusicModule.Views.Artist;
using MusicPlayer.MusicModule.Views.Genres;
using MusicPlayer.MusicModule.Views.Matches;
using MusicPlayer.MusicModule.Views.Songs;
using MusicPlayer.MusicModule.Views.ToolBar;
using AlbumDetailsView = MusicPlayer.MusicModule.Views.Albums.AlbumDetailsView;
using AlbumsView = MusicPlayer.MusicModule.Views.Albums.AlbumsView;
using ArtistDetailsView = MusicPlayer.MusicModule.Views.Artist.ArtistDetailsView;
using ArtistView = MusicPlayer.MusicModule.Views.Artist.ArtistView;

namespace MusicPlayer.MusicModule
{
    public class MusicModule : IModule
    {

        private readonly IUnityContainer container;
        private readonly IRegionManager regionManager;

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private MainRegionController _mainRegionController;

        public MusicModule(IUnityContainer container, IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }
        public void Initialize()
        {
            this.container.RegisterType<IMusicDataService, MusicDataService>();

            this.regionManager.RegisterViewWithRegion(RegionNames.ToolBarRegion,
                                                      () => this.container.Resolve<ToolBarView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.MainRegion,
                                                       () => this.container.Resolve<MusicDetailsView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.ArtistsLeftRegion,
                                                      () => this.container.Resolve<ArtistListView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.AlbumLeftRegion,
                                                     () => this.container.Resolve<AlbumsListView>());

            this._mainRegionController = this.container.Resolve<MainRegionController>();

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<SongsView>());
           

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<AlbumsView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<ArtistView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<GenresView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<Views.PLList.PLListView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.TabRegion,
                                                       () => this.container.Resolve<MatchView>());

            this.regionManager.RegisterViewWithRegion(RegionNames.AlbumRightRegion,
                                                       () => this.container.Resolve<AlbumDetailsView>());

            

            this.regionManager.RegisterViewWithRegion(RegionNames.ArtistsRightRegion,
                                                      () => this.container.Resolve<ArtistDetailsView>());

            this.regionManager.RequestNavigate(RegionNames.SongsLeftRegion, RegionNames.AlbumLeftRegion);

        }
    }
}
