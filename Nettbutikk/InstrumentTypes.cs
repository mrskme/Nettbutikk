using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class InstrumentTypes
    {
        public List<InstrumentType> All;
        public InstrumentType Woodwind;
        public InstrumentType Brass;
        public InstrumentType String;
        public InstrumentType Percussion;

        public InstrumentTypes()
        {
            Woodwind = new InstrumentType("Woodwind");
            Brass = new InstrumentType("Brass");
            String = new InstrumentType("String");
            Percussion = new InstrumentType("Percussion");

            All = new List<InstrumentType>
            {
                Woodwind,
                Brass,
                String,
                Percussion,
            };
        }
    }
}
