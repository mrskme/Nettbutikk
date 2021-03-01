using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Instrument
    {
        public string Name;
        public InstrumentType Type;

        public Instrument(string name, InstrumentType type)
        {
            Name = name;
            Type = type;
        }
    }
}
