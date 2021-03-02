using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class LedZeppelinAlbum : Album
    {
        public Song GoodTimesBadTimes;
        public Song BabeImGonnaLeaveYou;
        public Song YouShookMe;
        public Song DazedandConfused;
        public Song YourTimeIsGonnaCome;
        public Song BlackMountainSide;
        public Song CommunicationBreakdown;
        public Song ICantQuitYouBaby;
        public Song HowManyMoreTimes;
        public LedZeppelinAlbum(string name, int releaseDate, Genre genre) : base(name, releaseDate, genre)
        {
            GoodTimesBadTimes = new Song("Good Times Bad Times");
            BabeImGonnaLeaveYou = new Song("Babe I'm Gonna Leave You");
            YouShookMe = new Song("You Shook Me");
            DazedandConfused = new Song("Dazed and Confused");
            YourTimeIsGonnaCome = new Song("Your Time Is Gonna Come");
            BlackMountainSide = new Song("Black Mountain Side");
            CommunicationBreakdown = new Song("Communication Breakdown");
            ICantQuitYouBaby = new Song("I Can't Quit You Baby");
            HowManyMoreTimes = new Song("How Many More Times");
        }
    }
}
