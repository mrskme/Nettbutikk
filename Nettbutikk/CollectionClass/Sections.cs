using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Sections
    {
        public List<Section> All { get; }
        public Section A { get; }

        private Bands Bands;


        public Sections()
        {
            Bands = new Bands();
            A = new Section(Bands.LedZeppelin);
            All = new List<Section>()
            {
                A,
            };
        }
    }
}
