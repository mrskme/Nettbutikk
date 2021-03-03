using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Member
    {
        public string Name;
        public string ArtistName;
        public Instrument Instrument;

        public Member(string name, string artistName, Instrument instrument)
        {
            Name = name;
            ArtistName = artistName;
            Instrument = instrument;
        }

        public string MakeMemberStr()
        {
            var str = $"Name: {Name}, Artist Name: {ArtistName}, Instrument: {Instrument.Name}\n";
            return str;
        }

        public string MakeMemberNameStr()
        {
            var str = $"Name: {Name}\n";
            return str;
        }
    }
}
