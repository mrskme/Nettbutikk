using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Mothership : Album
    {
        public Song GoodTimesBadTimes;
        public Song CommunicationBreakdown;
        public Song DazedAndConfused;
        public Song BabeImGonnaLeaveYou;
        public Song WholeLottaLove;
        public Song RambleOn;
        public Song Heartbreaker;
        public Song ImmigrantSong;
        public Song SinceIveBeenLovingYou;
        public Song RockandRoll;
        public Song BlackDog;
        public Song WhentheLeveeBreaks;
        public Song StairwaytoHeaven;

        public Mothership(string name, int releaseDate, Genre genre) : base(name, releaseDate, genre)
        {
            GoodTimesBadTimes = new Song("Good Times Bad Times");
            CommunicationBreakdown = new Song("Communication Breakdown");
            DazedAndConfused = new Song("Dazed and Confused");
            BabeImGonnaLeaveYou = new Song("Babe I'm Gonna Leave You");
            WholeLottaLove = new Song("Whole Lotta Love");
            RambleOn = new Song("Ramble On");
            Heartbreaker = new Song("Heartbreaker");
            ImmigrantSong = new Song("Immigrant Song");
            SinceIveBeenLovingYou = new Song("Since I've Been Loving You");
            RockandRoll = new Song("Rock and Roll");
            BlackDog = new Song("Black Dog");
            WhentheLeveeBreaks = new Song("When the Levee Breaks");
            StairwaytoHeaven = new Song("Stairway to Heaven");

            All = new List<Song>
            {
                GoodTimesBadTimes,
                CommunicationBreakdown,
                DazedAndConfused,
                BabeImGonnaLeaveYou,
                WholeLottaLove,
                RambleOn,
                Heartbreaker,
                ImmigrantSong,
                SinceIveBeenLovingYou,
                RockandRoll,
                BlackDog,
                WhentheLeveeBreaks,
                StairwaytoHeaven,
            };
        }

    }
}
