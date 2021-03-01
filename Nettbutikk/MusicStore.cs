using System;
using System.Collections.Generic;
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

        public void WriteLedZeppelinsAlbums()
        {
            foreach (var album in Sections.SectionLedZeppelin.Albums)
            {
                Console.WriteLine(album.Band.Name);
                Console.WriteLine(album.Genre.Name);
                Console.WriteLine(album.ReleaseDate);
                foreach (var song in album.Songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            
        }
    }
}