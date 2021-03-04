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

        public void RunUI()
        {
            _handleCommand = new HandleCommand();
            _handleCommand.RunUI();
        }

        //private void Specific()
        //{
        //    LoopTilSuccess(_handleCommand.BandSelection);
        //    Response response;
        //    do
        //    {
        //        var command2 = Console.ReadLine();
        //        if (command2 == "Album") response = LoopTilSuccess(_handleCommand.AlbumSelection);
        //        else if (command2 == "Members") response = LoopTilSuccess(_handleCommand.MemebersSelection);
        //        else
        //        {
        //            response = new Response("This is not a valid search");
        //            response.WriteMessage();
        //        }
        //    } while (!response.IsSuccess);
        //}

        //private Response LoopTilSuccess(Func<Response> selectionHandler)
        //{
        //    Response response;
        //    do
        //    {
        //        response = selectionHandler();
        //        response.WriteMessage();
        //    } while (!response.IsSuccess);

        //    return response;
        //}
    }
}