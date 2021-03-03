using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Homework :Album
    {

        public Song DaFunk,
            Daftendirekt,
            WDPK837FM,
            Revolution909,
            Phœnix,
            Fresh,
            AroundtheWorld,
            RollinAndScratchin,
            Teachers,
            HighFidelity,
            RocknRoll,
            OhYeah
            ;

        public Homework(string name, int releaseDate, Genre genre) : base(name, releaseDate, genre)
        {
            DaFunk = new Song("Da Funk");
            Daftendirekt = new Song("Daftendirekt");
            WDPK837FM = new Song("WDPK 83.7 FM");
            Revolution909 = new Song("Revolution 909");
            Phœnix = new Song("Phœnix");
            Fresh = new Song("Fresh");
            AroundtheWorld = new Song("Around the World");
            RollinAndScratchin = new Song("RollinAndScratchin");
            Teachers = new Song("Teachers");
            HighFidelity = new Song("HighFidelity");
            RocknRoll = new Song("Rock'n Roll");
            OhYeah = new Song("Oh Yeah");


            All = new List<Song>
            {
                DaFunk, 
                Daftendirekt, 
                WDPK837FM, 
                Revolution909, 
                Phœnix,
                Fresh,
                AroundtheWorld,
                RollinAndScratchin,
                Teachers,
                HighFidelity,
                RocknRoll,
                OhYeah,
                //Burning,
                //IndoSilverClub,
                //Alive,
                //FunkAd
            };
        }
    }
}
