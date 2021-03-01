using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Sections
    {
        public List<Section> All;
        public Section SectionLedZeppelin;
        public Bands Bands;


        public Sections()
        {
            Bands = new Bands();
            SectionLedZeppelin = new Section(Bands.LedZeppelin);
            All = new List<Section>()
            {
                SectionLedZeppelin,
            };
        }
    }
}
