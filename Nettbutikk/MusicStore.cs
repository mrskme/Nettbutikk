using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nettbutikk
{
    class MusicStore
    {
        private HandleCommand _handleCommand;

        public void MusicSelection()
        {
            _handleCommand = new HandleCommand();

            Selection(_handleCommand.HandleSectionSelection);

            var command = Console.ReadLine();
            if (command == "Album") Selection(_handleCommand.HandleAlbumSelection);
            if (command == "Members") Selection(_handleCommand.HandleMmebersSelection);

            //return GoAgain();
        }

        //private bool GoAgain()
        //{
        //    Console.WriteLine("Write \"again\" to go again");
        //    var command = Console.ReadLine();
        //    if (command == "again") return true;
        //    return false;
        //}

        private void Selection(Func<Response> selectionHandler)
        {
            Response response;
            do
            {
                response = selectionHandler();
                response.WriteMessage();
            } while (!response.IsSuccess);
        }
    }
}