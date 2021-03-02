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

        private Bands Bands;


        public Sections()
        {
            Bands = new Bands();
            LedZeppelin = new Section(Bands.LedZeppelin);
            All = new List<Section>()
            {
                LedZeppelin,
            };
        }

        public Section GetSection(string command) 
            => All.FirstOrDefault(S => S.Band.Name == command);

        public string MakeBandNamesStr()
        {
            var str = string.Empty;
            foreach (var band in Bands.All)
            {
                str += band.MakeNameStr();
            }

            return str;
        }
    }
}
