using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Instruments
    {
        public InstrumentTypes InstrumentTypes;
        public List<Instrument> All;
        public Instrument Guitar, Drumset, KeyBoard, DJ;

        public Instruments()
        {
            InstrumentTypes = new InstrumentTypes();
            Guitar = new Instrument("Guitar", InstrumentTypes.String);
            Drumset = new Instrument("Drumset", InstrumentTypes.Percussion);
            KeyBoard = new Instrument("Keyboard", InstrumentTypes.Electronic);
            DJ = new Instrument("DJ", InstrumentTypes.Electronic);
            All = new List<Instrument>
            {
                Guitar,
                Drumset,
                KeyBoard,
                DJ,
            };
        }
    }
}
