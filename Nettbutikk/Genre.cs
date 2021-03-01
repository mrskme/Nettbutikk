using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

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

        public string MakeNameStr()
        {
            var str = $"Genre name : {Name}\n";
            return str;
        }
        public string MakeVolumLevelStr()
        {
            var str = $"Genre volume level : {VolumeLevel}\n";
            return str;
        }
        public string MakeFeelingStr()
        {
            var str = $"Genre feeling : {Feeling}\n";
            return str;
        }
    }
}
