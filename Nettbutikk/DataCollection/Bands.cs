using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Bands
    {
        public List<Band> All;
        public Band LedZeppelin, DaftPunk;
        public Members Members;
        public Genres Genres;
        public Albums Albums;
        
        public Bands()
        {
            Genres = new Genres();
            Members = new Members();
            Albums = new Albums(); 
            
            LedZeppelin = new Band("Led Zeppelin", Members.LedZeppelin, "England", Genres.Rock, Albums.LedZeppelin);
            DaftPunk = new Band("Daft Punk", Members.Daftpunk, "France", Genres.Electric, Albums.DaftPunk);
            
            All = new List<Band>
            {
                LedZeppelin, 
                DaftPunk,
            };
        }
    }
}
