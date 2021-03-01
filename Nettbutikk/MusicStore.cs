using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class MusicStore
    {
        private Sections Sections;

        public MusicStore()
        {
            Sections = new Sections();
        }

        public void WriteLedZeppelinsAlbums()
        {
            Console.WriteLine(Sections.SectionLedZeppelin.Albums[0].Songs[0].Name);
        }
    }
}