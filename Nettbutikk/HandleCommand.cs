using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class HandleCommand
    {
        private Section _currentSection;
        private Band _currentBand;
        private Album _currentAlbum;

        public HandleCommand()
        {
            
        }
        public Response HandleSectionSelection(Sections sections)
        {
            Console.Write("Choose band to inspect\nBands:\n");
            var bandNamesStr = sections.MakeBandNamesStr();
            Console.Write(bandNamesStr);
            
            var command = Console.ReadLine();
            _currentSection = sections.GetSection(command);
            string message;
            if (_currentSection == null)
            {
                message = "This section is not available";
                return new Response(message);
            }
            _currentBand = _currentSection.Band;
            
            message = $"Albums: \n{_currentBand.MakeAllAlbumsString()}";
            return new Response(message, true);
        }

        //hvis det er failure kall metoden på nytt med while?

        public Response HandleAlbumSelection()
        {
            var command = Console.ReadLine();
            _currentAlbum = _currentBand.Albums.FirstOrDefault(A => A.Name == command);

            string message;
            if (_currentAlbum == null)
            {
                message = "This is an incorrect album name";
                return new Response(message);
            }
            message = "Songs: \n";
            message += _currentAlbum.MakeSongsStr();
            return new Response(message, true);
        }
    }
}
