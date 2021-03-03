using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class Sections
    {
        public List<Section> All { get; }
        public Section LedZeppelin { get; }
        public Section DaftPunk {get;}

        private readonly Bands _bands;

        public Sections()
        {
            _bands = new Bands();
            LedZeppelin = new Section(_bands.LedZeppelin);
            DaftPunk = new Section(_bands.DaftPunk);
            All = new List<Section>()
            {
                LedZeppelin,
                DaftPunk,
            };
        }

        public Section GetSection(string command) 
            => All.FirstOrDefault(S => S.Band.Name == command);

        public string MakeBandNamesStr()
        {
            var str = string.Empty;
            foreach (var band in _bands.All)
            {
                str += "  " + band.MakeNameStr();
            }
            return str;
        }
    }
}
