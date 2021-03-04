using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Nettbutikk
{
    class MusicStore
    {
        private HandleCommand _handleCommand;

        public void MusicSelection()
        {
            _handleCommand = new HandleCommand();
            while (true)
            {
                _handleCommand.WriteBands();
                Console.WriteLine("Write \"Specific\" to go into a specified band");
                Console.WriteLine("Write \"General\" to search through all bands for something specified");
                Console.WriteLine("Write \"Exit\" to exit program");

                var command1 = Console.ReadLine();
                if (command1 == "Exit") return;
                else if (command1 == "Specific")
                {
                    Specific();
                }

                else if (command1 == "General")
                {
                     Selection(_handleCommand.General);
                }
                else Console.WriteLine("This is not a valid command");
            }
        }

        private void Specific()
        {
            Selection(_handleCommand.SectionSelection);
            Response response;
            do
            {
                var command2 = Console.ReadLine();
                if (command2 == "Album") response = Selection(_handleCommand.AlbumSelection);
                else if (command2 == "Members") response = Selection(_handleCommand.MemebersSelection);
                else
                {
                    response = new Response("Dette er ikke et godkjent søk");
                    response.WriteMessage();
                }
            } while (!response.IsSuccess);
        }

        private Response Selection(Func<Response> selectionHandler)
        {
            Response response;
            do
            {
                response = selectionHandler();
                response.WriteMessage();
            } while (!response.IsSuccess);

            return response;
        }
    }
}