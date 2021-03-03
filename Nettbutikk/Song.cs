using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Song
    {
        public string Name;

        public Song(string name)
        {
            Name = name;
        }

        public string MakeSongStr(int i)
        {
            var str = $"  {i} {Name}\n";
            return str;
        }
    }
}
