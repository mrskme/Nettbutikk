using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Genre
    {
        public string Name;
        public int VolumeLevel;
        public string Feeling;

        public Genre(string name, int volumeLevel, string feeling)
        {
            Name = name;
            VolumeLevel = volumeLevel;
            Feeling = feeling;
        }
    }
}
