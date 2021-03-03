using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Album
    {
        public string Name;
        public int ReleaseDate;
        public Genre Genre;
        public List<Song> All;

        public Album(string name, int releaseDate, Genre genre)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Genre = genre;
        }

        public string MakeAlbumNameStr()
        {
            var str = $"{Name}\n";
            return str;
        }
        public string MakeAlbumStr()
        {
            var str = $"{Name}\n  Release date: {ReleaseDate}\n  {Genre.MakeNameStr()}";
            return str;
        }

        public string MakeSongsStr()
        {
            var str = string.Empty;
            for (var index = 0; index < All.Count; index++)
            {
                str += All[index].MakeSongStr(index + 1);
            }
            return str;
        }
    }
}
