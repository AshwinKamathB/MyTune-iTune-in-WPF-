using System;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using MusicPlayer.MusicModule.Model;

namespace MusicPlayer.MusicModule.Services
{
    public class MusicDataService : IMusicDataService
    {
        private Albums Albums;

        public Albums GetAlbums()
        {
            if (Albums == null)
            {
                Albums = new Albums()
                {
                    new Album()
                    {
                        Id=1,
                        Length = "53:52",
                        AlbumArtUrl = new BitmapImage(new Uri(@"pack://application:,,,/Images/gunsandroses.jpg")),
                        Artist = new Artist()
                        {
                            ArtistId = 1,
                            Image = new BitmapImage(new Uri(@"pack://application:,,,/Images/Artist2.jpg")),
                            Name = "Guns N Roses"
                        },
                        Price = 18,
                        ReleaseYear = "1987",
                        Title = "Appetite for Destruction",
                        Genre = new Genre()
                        {
                            GenreId = 1,
                            Description =
                                "Appetite for Destruction is the debut studio album by American hard rock band Guns N' Roses. It was released on July 21, 1987, by Geffen Records to massive commercial success.",
                            Name = "Heavy metal, Hard rock, Glam metal"
                        },
                        Songs = new List<Song>()
                        {
                            new Song {Name = "Welcome to the Jungle", Id = 1, Duration = "4:34"},
                            new Song {Name = "It's So Easy", Id = 2, Duration = "3:21"},
                            new Song {Name = "Nightrain", Id = 3, Duration = "4:26"},
                            new Song {Name = "Out ta Get Me", Id = 4, Duration = "4:20"},
                            new Song {Name = "Mr. Brownstone", Id = 5, Duration = "3:46"},
                            new Song {Name = "Paradise City", Id = 6, Duration = "6:46"},
                            new Song {Name = "My Michelle", Id = 7, Duration = "3:39"},
                            new Song {Name = "Think About You", Id = 8, Duration = "3:50"},
                            new Song {Name = "Sweet Child o' Mine", Id = 9, Duration = "5:55"},
                            new Song {Name = "You're Crazy", Id = 10, Duration = "3:16"},
                            new Song {Name = "Anything Goes", Id = 11, Duration = "3:25"},
                            new Song {Name = "Rocket Queen", Id = 12, Duration = "6:13"},
                        }

                    },

                     new Album()
                    {
                        Id=4,
                        Length = "	01:00:01",
                        AlbumArtUrl = new BitmapImage(new Uri(@"pack://application:,,,/Images/BrazNight.jpg")),
                        Artist = new Artist()
                        {
                            ArtistId = 3,
                            Image = new BitmapImage(new Uri(@"pack://application:,,,/Images/KennyG.jpg")),
                            Name = "Kenny G"
                        },
                        Price = 18,
                        ReleaseYear = "2015",
                        Title ="Brazilian Nights" ,
                        Genre = new Genre()
                        {
                            GenreId = 1,
                            Description =
                                "Brazilian Nights is the fifteenth studio album by Kenny G, released on January 27, 2015, his second bossa nova album, following Rhythm & Romance released in 2008.",
                            Name = "Latin jazz, Smooth jazz"
                        },
                        Songs = new List<Song>()
                        {
                            new Song {Name = 	"Bossa Antigua", Id = 1, Duration = "3:48"},
                            new Song {Name = 	"Corcovado (Quiet Nights Of Quiet Stars)"  , Id = 2, Duration = "7:30"},
                            new Song {Name = "Bossa Réal"  , Id = 3, Duration = "7:36"},
                            new Song {Name = "Brazilian Nights"  , Id = 4, Duration = "6:38"},
                            new Song {Name = "April Rain"  , Id = 5, Duration = "6:48"},
                            new Song {Name = "Menina Moca", Id = 6, Duration = "5:57"},
                            new Song {Name ="Bu Bossa" , Id = 7, Duration = "4:25"},
                            new Song {Name = 	"Clouds", Id = 8, Duration = "5:37"},
                            new Song {Name = 	"Girl From Ipanema"  , Id = 9, Duration = "5:33"},
                            new Song {Name = "Summer Love"  , Id = 10, Duration = "6:15"}
                        }

                    },

                    new Album()
                    {
                        Id=2,
                        Length = "41:13",
                        AlbumArtUrl = new BitmapImage(new Uri(@"pack://application:,,,/Images/blackstar.jpg")),
                        Artist = new Artist()
                        {
                            ArtistId = 2,
                            Image = new BitmapImage(new Uri(@"pack://application:,,,/Images/Artist1.jpg")),
                            Name = "David Bowie"
                        },
                        Price = 18,
                        ReleaseYear = "2016",
                        Title = "Blackstar",
                        Genre = new Genre()
                        {
                            GenreId = 1,
                            Description =
                                "is the twenty-fifth and final studio album by the English musician David Bowie, released worldwide through ISO, RCA, Columbia, and Sony on 8 January 2016, coinciding with Bowie's 69th birthday.",
                            Name = "Art rock, jazz, experimental rock"
                        },
                        Songs = new List<Song>()
                        {
                            new Song {Name = "Blackstar"  , Id = 1, Duration = "9:57"},
                            new Song {Name = "Tis a Pity She Was a Whore"  , Id = 2, Duration = "4:52"},
                            new Song {Name = 	"Lazarus"  , Id = 3, Duration = "6:22"},
                            new Song {Name = "Sue (Or in a Season of Crime)" , Id = 4, Duration = "4:40"},
                            new Song {Name = 	"Girl Loves Me"  , Id = 5, Duration = "4:51"},
                            new Song {Name = 	"Dollar Days"  , Id = 6, Duration = "6:46"},
                            new Song {Name = "My Michelle", Id = 7, Duration = "4:44"},
                            new Song {Name = 	"I Can't Give Everything Away"  , Id = 8, Duration = "5:47"}
                        }
                        

                    },

                     new Album()
                    {
                        Id=3,
                        Length = "53:17",
                        AlbumArtUrl = new BitmapImage(new Uri(@"pack://application:,,,/Images/The_Next_Day.png")),
                        Artist = new Artist()
                        {
                            ArtistId = 2,
                            Image = new BitmapImage(new Uri(@"pack://application:,,,/Images/Artist1.jpg")),
                            Name = "David Bowie"
                        },
                        Price = 18,
                        ReleaseYear = "2013",
                        Title = "The Next Day",
                        Genre = new Genre()
                        {
                            GenreId = 1,
                            Description =
                                "The Next Day is the twenty-fourth studio album by musician David Bowie, released on 8 March 2013 on his ISO Records label, under exclusive licence to Columbia Records. The album was announced on Bowie's sixty-sixth birthday, 8 January 2013.",
                            Name = "Art rock"
                        },
                        Songs = new List<Song>()
                        {
                            new Song {Name =	"The Next Day"  , Id = 1, Duration = "3:27"},
                            new Song {Name = "Dirty Boys"  , Id = 2, Duration = "2:58"},
                            new Song {Name = "The Stars (Are Out Tonight)"  , Id = 3, Duration = "3:56"},
                            new Song {Name = 	"Love Is Lost"  , Id = 4, Duration = "3:57"},
                            new Song {Name = 	"Where Are We Now?", Id = 5, Duration = "4:08"},
                            new Song {Name = "Valentine's Day"  , Id = 6, Duration = "3:01"},
                            new Song {Name = 	"If You Can See Me", Id = 7, Duration = "3:15"},
                            new Song {Name = "I'd Rather Be High"  , Id = 8, Duration = "3:53"},
                            new Song {Name = 	"Boss of Me" , Id = 9, Duration = "4:09"},
                            new Song {Name = 	"Dancing Out in Space" , Id = 10, Duration = "3:24"},
                            new Song {Name = "How Does the Grass Grow?" , Id = 11, Duration = "4:33"},
                            new Song {Name = "(You Will) Set the World On Fire", Id = 13, Duration = "3:30"},
                            new Song {Name = "You Feel So Lonely You Could Die"  , Id = 14, Duration = "4:37"},
                            new Song {Name = "Heat", Id = 12, Duration = "4:25"},
                        }

                    }
                };
            }

            return Albums;
        }
    }
}
