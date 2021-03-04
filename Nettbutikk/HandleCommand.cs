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
        public Response SectionSelection()
        {
            Console.Write("Choose a band to inspect\n");

            var command = Console.ReadLine();
            _currentSection = _sections.GetSection(command);
            string message;
            if (_currentSection == null)
            {
                message = "This section is not available";
                return new Response(message);
            }
            _currentBand = _currentSection.Band;
            message = $"{_currentBand.MakeCountryStr()}{_currentBand.MakeFullGenreStr()}\n";
            message += "Write \"Album\" to see albums\nWrite \"Members\" to see members of the band\n";
            return new Response(message, true);
        }

        public Response AlbumSelection()
        {
            var albums = $"Albums: \n{_currentBand.MakeAllAlbumsString()}\n";
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

        public Response MemebersSelection()
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

        public Response General()
        {
            Console.Write("Write \"Band\" to search through all bands after specified condition\n");
            Console.Write("Write \"Artist\" to search through all bands after specified condition\n");
            Console.Write("Write \"Album\" to search through all bands after specified condition\n");

            var command1 = Console.ReadLine();
            if (command1 == "Band")
            {
                Console.Write("Search through all bands to see which bands has what\n"); 
                Console.Write("Write \"Instrument\" to search for instruments\n"); 
                Console.Write("Write \"Instrument type\" to search for instrument types\n"); 
                Console.Write("Write \"Member\" to search for member(s)\n");
                var response = GeneralBandLoop();
                return response;
            }
            if (command1 == "Artist") return new Response("asd");
            if (command1 == "Album") return new Response("asd");
                //lag kode

            return new Response("kake");
        }

        public Response GeneralBandLoop()
        {
            
            Response response;
            do
            {
                response = GeneralBand();
                response.WriteMessage();
            } while (!response.IsSuccess);

            return response;
        }

        private Response GeneralBand()
        {
            var command2 = Console.ReadLine();
            if (command2 == "Instrument")
            {
                var response = GeneralBandInstrument();
                return response;
            }

            if (command2 == "Instrument type")
            {
                var response = GeneralBandInstrumentType();
                return response;
            }

            if (command2 == "Member")
            {
                var response = GeneralBandMember();
                return response;
            }

            return new Response("Incorrect command");
        }

        private Response GeneralBandMember()
        {
            Console.Write("Write the name of am music artist you want to search for");
            var command3 = Console.ReadLine();
            //DosStuff3(command3)
            return new Response("AllMembers",true);
        }

        private Response GeneralBandInstrumentType()
        {
            Console.Write("Write the instrument type to search for");
            //console write all instrument types
            var command3 = Console.ReadLine();
            //DosStuff2(command3)
            return new Response("asdasd",true);
        }

        private  Response GeneralBandInstrument()
        {
            Console.Write("Write the name of an instrument to search for");
            //Console write all instruments
            var command3 = Console.ReadLine();
            //DosStuff¨1(command3)
            return new Response("asdasd");
        }

        public void WriteBands()
        {
            var bandNamesStr = "Bands:\n" +  _sections.MakeBandNamesStr();
            Console.Write(bandNamesStr);
        }
    }
}
