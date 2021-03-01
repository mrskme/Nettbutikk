using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Album
    {
        public string Name;
        public int ReleaseDate;
        public Band Band;
        public Genre Genre;
        public List<Song> Songs;

        public Album(string name, int releaseDate, Band band, Genre genre, List<Song> songs)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Band = band;
            Genre = genre;
            Songs = songs;
        }
        public string WriteAlbum()
        {
            var str = string.Empty;
            str += Band.MakeMembersInBandStr();
            return str;
        }
    }
}
