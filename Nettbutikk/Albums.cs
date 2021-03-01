using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Albums
    {
        public List<Album> All;
        public Songs Songs;
        public Album Mothership;
        public Bands Bands;
        public Genres Genres;

        public Albums()
        {
            Songs = new Songs();
            Bands = new Bands();
            Genres = new Genres();
            

            Mothership = new Album("Mothership",2007, Bands.LedZeppelin, Genres.Rock, new List<Song>() {Songs.GoodTimesBadTimes, Songs.CommunicationBreakdown});

            All = new List<Album>
            {
                Mothership,
            };

        }
    }
}
