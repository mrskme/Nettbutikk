using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Band
    {
        public string Name;
        public List<Member> Members;
        public string Country;
        public Genre Genre;
        public List<Album> Albums;

        public Band(string name, List<Member> members, string country, Genre genre, List<Album> albums)
        {
            Name = name;
            Members = members;
            Country = country;
            Genre = genre;
            Albums = albums;
        }

        public string MakeNameStr()
        {
            var str = $"Band: {Name}\n";
            return str;
        }
        public string MakeMembersInBandStr()
        {
            var str = string.Empty;
            foreach (var member in Members)
            {
                str += member.MakeMemberStr();
            }
            return str;
        }

        public string MakeCountryStr()
        {
            var str = $"Band Origin: {Country}\n";
            return str;
        }

        public string MakeFullGenreStr()
        {
            var str = string.Empty;
            str += Genre.MakeNameStr();
            str += Genre.MakeVolumLevelStr();
            str += Genre.MakeFeelingStr();
            return str;
        }

        public string MakeAllAlbumsString()
        {
            var str = string.Empty;
            foreach (var album in Albums)
            {
                str += album.MakeAlbumStr();
            }
            return str;
        }
    }
}
