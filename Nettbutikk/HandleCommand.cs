using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class HandleCommand
    {
        protected readonly Bands _bands;

        protected Band _currentBand;
        protected Album _currentAlbum;
        protected Member _currentMember;

        protected string CurrentCommand;

        public HandleCommand()
        {
            _bands = new Bands();
        }
        public void RunUI()
        {
            while (true)
            {
                WriteBands();
                Console.WriteLine("Write \"Specific\" to go into a specified band");
                Console.WriteLine("Write \"General\" to search through all bands for something specified");
                Console.WriteLine("Write \"Exit\" to exit program");

                var command1 = Console.ReadLine();
                if (command1 == "Exit") return;
                else if (command1 == "Specific")
                {
                    LoopTilSuccess(Specific);
                }

                else if (command1 == "General")
                {
                    LoopTilSuccess(General);
                }
                else Console.WriteLine("This is not a valid command");
            }
        }
        public Response Specific()
        {
            LoopTilSuccess(BandSelection);
            Response response;

            var command2 = Console.ReadLine();
            if (command2 == "Album") response = LoopTilSuccess(AlbumSelection);
            else if (command2 == "Members") response = LoopTilSuccess(MemebersSelection);
            else response = new Response("This is not a valid search");

            return response;
        }
        public Response General()
        {
            Console.Write("Write \"Band\" to search through all bands after specified condition\n" +
                          "Write \"Artist\" to search through all bands after specified condition\n" +
                          "Write \"Album\" to search through all bands after specified condition\n");

            var command1 = Console.ReadLine();
            if (command1 == "Band")
            {
                Console.Write("Search through all bands to see which bands has what\n" +
                              "Write \"Instrument\" to search for instruments\n" +
                              "Write \"Instrument type\" to search for instrument types\n" +
                              "Write \"Music artist\" to search for member(s)\n");

                var response = LoopTilSuccess(GeneralBand);
                return response;
            }
            if (command1 == "Artist") return new Response("asd");
            if (command1 == "Album") return new Response("asd");
            //lag kode

            return new Response("This is not a valid command");
        }
        public Response BandSelection()
        {
            Console.Write("Choose a band to inspect\n");

            var command = Console.ReadLine();
            var band = _bands.GetBand(command);
            string message;
            if (band == null)
            {
                message = "This band is not available";
                return new Response(message);
            }
            _currentBand = band;
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
        //12312312
        public Response LoopTilSuccess(Func<Response> selectionHandler)
        {
            Response response;
            do
            {
                response = selectionHandler();
                response.WriteMessage();
            } while (!response.IsSuccess);

            return response;
        }
        //123123123

        private Response GeneralBand()
        {
            var command2 = Console.ReadLine();
            CurrentCommand = command2;
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

            if (command2 == "Music artist")
            {
                var response = LoopTilSuccess(GeneralBandMembersSearch);
                return response;
            }

            return new Response("Incorrect command");
        }

        private Response GeneralBandMembersSearch() //Denne writer message i LoopTilSuccess flere ganger
        {
            Console.Write($"Write the name of the {CurrentCommand} you want to search for");
            List<Band> bands;
            do
            {
                var command3 = Console.ReadLine();
                bands = _bands.All.FindAll(b => b.Members.Any(m =>
                    command3 != null && (string.Equals(m.Name.ToLower(), command3.ToLower()) ||
                                         string.Equals(m.ArtistName.ToLower(), command3.ToLower())))); // select? 

            } while (bands.Count >= 1);
            var searchResult = string.Empty;
            foreach (var band in bands)
            {
                searchResult += band.MakeNameStr();
            }
            return new Response(searchResult, true);
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
            var bandNamesStr = "Bands:\n" +  _bands.MakeBandNamesStr();
            Console.Write(bandNamesStr);
        }
    }
}
