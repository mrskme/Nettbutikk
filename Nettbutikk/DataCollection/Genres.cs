using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Genres
    {
        public Genre Rock, Electric;
        public Genres()
        {
            Rock = new Genre("Rock", 9, "Good");
            Electric = new Genre("Electric", 8, "Sweet");
        }
    }
}
