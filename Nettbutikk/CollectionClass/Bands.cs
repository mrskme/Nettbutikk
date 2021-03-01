using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Bands
    {
        public List<Band> All;
        public Band LedZeppelin;
        public Members Members;
        public Genres Genres;

        public Bands()
        {
            Genres = new Genres();
            Members = new Members();
            LedZeppelin = new Band("Led Zeppelin", Members.LedZeppelin, "England", Genres.Rock);
            All = new List<Band>
            {
                LedZeppelin,
            };
        }
    }
}
