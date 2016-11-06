using Microsoft.Practices.Prism.PubSubEvents;

namespace MusicPlayer.MusicModule.Events
{
    public class AlbumSelectedEvent :PubSubEvent<int>
    {
    }
}