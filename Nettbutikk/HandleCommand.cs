using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class HandleCommand
    {
        private readonly Sections _sections;

        private Section _currentSection;
        private Band _currentBand;
        private Album _currentAlbum;
        private Member _currentMember;

        public HandleCommand()
        {
            _sections = new Sections();
        }
        public Response HandleSectionSelection()
        {
            Console.Write("Choose band to inspect\nBands:\n");
            var bandNamesStr = _sections.MakeBandNamesStr();
            Console.Write(bandNamesStr);
            
            var command = Console.ReadLine();
            _currentSection = _sections.GetSection(command);
            string message;
            if (_currentSection == null)
            {
                message = "This section is not available";
                return new Response(message);
            }
            _currentBand = _currentSection.Band;
            
            message = "Write \"Album\" to see albums\nWrite \"Members\" to see members of the band\n";
            return new Response(message, true);
        }

        //hvis det er failure kall metoden på nytt med while?

        public Response HandleAlbumSelection()
        {
            var albums = $"Albums: \n{_currentBand.MakeAllAlbumsString()}";
            Console.Write(albums + "Choose an album to inspect\n");
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

        public Response HandleMmebersSelection()
        {
            var members = $"Members: \n{_currentBand.MameMembersNameString()}";
            Console.Write(members + "Choose an member to inspect\n");
            var command = Console.ReadLine();
            _currentMember = _currentBand.Members.FirstOrDefault(A => A.Name == command || A.ArtistName == command);

            string message;
            if (_currentMember == null)
            {
                message = "This is an incorrect member";
                return new Response(message);
            }
            message = _currentMember.MakeMemberStr();
            return new Response(message, true);
        }
    }
}
