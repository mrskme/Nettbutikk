using System;
using System.Collections.Generic;

namespace Nettbutikk
{
    class Program
    {
        static void Main(string[] args)
        {
            var MusicStore = new MusicStore();
            Console.WriteLine("Write band name for info");
            Console.WriteLine("Bands: Led Zeppelin");
            var command = Console.ReadLine();
            MusicStore.GetSection(command);
        }
    }
}
