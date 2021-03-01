using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Songs
    {
        public List<Song> All;

        public Song GoodTimesBadTimes;
        public Song CommunicationBreakdown;

        public Songs()
        {
            GoodTimesBadTimes = new Song("Good Times Bad Times");
            CommunicationBreakdown = new Song("Communication Breakdown");

            All = new List<Song>
            {
                GoodTimesBadTimes,
                CommunicationBreakdown,
            };
        }
    }
}
