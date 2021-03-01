using System;
using System.Collections.Generic;
using System.Linq;
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

        public void GetSection(string bandName)
        {
            var section = Sections.All.First(S => S.Albums.Any(a => a.Band.Name == bandName));
            Console.WriteLine($"\nAlbums: ");
            foreach (var album in section.Albums)
            {
                Console.Write($"{album.Name}\n");
            }
            Console.WriteLine("What album do you want?");
            var command = Console.ReadLine();
            var chosenAlbum = section.Albums.First(A => A.Name == command);
            Console.WriteLine(chosenAlbum.WriteAlbum());
            
        }

        public string HandleCommand(string command)
        {
            return string.Empty;
        }

        
    }
}