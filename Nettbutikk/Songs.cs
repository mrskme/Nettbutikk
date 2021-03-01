using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Songs
    {
        public List<Song> All;

        public Song GoodTimesBadTimes;

        public Songs()
        {
            GoodTimesBadTimes = new Song("GoodTimesBadTimes");

            All = new List<Song>
            {
                GoodTimesBadTimes,
            };
        }
    }
}
