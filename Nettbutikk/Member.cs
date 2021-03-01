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
            var str = $"Name: {Name}\nArtist Name: {ArtistName}\nInstrument: {Instrument.Name}\n";
            return str;
        }
    }
}
