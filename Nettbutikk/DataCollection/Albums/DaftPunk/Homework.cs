using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Homework :Album
    {
        public Song DaFunk;

        public Homework(string name, int releaseDate, Genre genre) : base(name, releaseDate, genre)
        {
            DaFunk = new Song("Da Funk");

            All = new List<Song>
            {
                DaFunk,
            };
        }
    }
}
