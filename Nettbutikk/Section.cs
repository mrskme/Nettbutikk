using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class Section
    {
        public List<Album> Albums;
        private Albums AllAlbums;

        public Section(Band band)
        {
            AllAlbums = new Albums();
            Albums = AllAlbums.All.Where(A => A.Band == band).ToList();
        }
    }
}
