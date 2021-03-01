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

        public Band(string name, List<Member> members, string country, Genre genre)
        {
            Name = name;
            Members = members;
            Country = country;
            Genre = genre;
        }
    }
}
