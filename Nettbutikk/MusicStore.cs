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
            string command1;
            while (true)
            {
                _handleCommand.WriteBands();
                Console.WriteLine("Write \"Specific\" to go into a specified band");
                Console.WriteLine("Write \"General\" to search through all bands for something specified");
                Console.WriteLine("Write \"Exit\" to exit program");

                command1 = Console.ReadLine();
                if (command1 == "Exit") return;
                else if (command1 == "Specific")
                {
                    //fiks så den kjører igjen hvis man skriver feil
                    Selection(_handleCommand.SectionSelection);
                    var command2 = Console.ReadLine();
                    if (command2 == "Album") Selection(_handleCommand.AlbumSelection);
                    if (command2 == "Members") Selection(_handleCommand.MemebersSelection);
                }

                else if (command1 == "General")
                {
                    Selection(_handleCommand.General);
                }
            }
        }

        private void Selection(Func<Response> selectionHandler)
        {
            Response response;
            do
            {
                response = selectionHandler();
                response.WriteMessage();
                response.IsSuccess = true;
            } while (!response.IsSuccess);
        }
    }
}