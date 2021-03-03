using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nettbutikk;

namespace Nettbutikk
{
    class Albums
    {
        public List<List<Album>> All;
        public Genres Genres;
        public List<Album> LedZeppelin { get; }
        private Mothership Mothership;
        private LedZeppelinAlbum LedZeppelinAlbum;

        public List<Album> DaftPunk;
        private Homework Homework;

        public Albums()
        {
            Genres = new Genres();

            Mothership = new Mothership("Mothership",2007, Genres.Rock);
            LedZeppelinAlbum = new LedZeppelinAlbum("Led Zeppelin", 1969, Genres.Rock);

            LedZeppelin = new List<Album>
            {
                Mothership,
                LedZeppelinAlbum,
            }.OrderBy(A => A.ReleaseDate).ToList();

            Homework = new Homework("Home Work", 1997, Genres.Electric);
            DaftPunk = new List<Album> 
            {
                Homework
            };
            All = new List<List<Album>>
            {
                LedZeppelin, DaftPunk,
            };
        }

        public void GetCorrectAlbum()
        {

        }

    }
}
