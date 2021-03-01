using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Instruments
    {
        public InstrumentTypes InstrumentTypes;
        public List<Instrument> All;
        public Instrument Guitar;

        public Instruments()
        {
            InstrumentTypes = new InstrumentTypes();
            Guitar = new Instrument("Guitar", InstrumentTypes.String);

            All = new List<Instrument>
            {
                Guitar,
            };
        }
    }
}
