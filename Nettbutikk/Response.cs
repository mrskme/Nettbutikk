using System;
using System.Collections.Generic;
using System.Text;

namespace Nettbutikk
{
    class Response
    {
        public string Message;
        public bool IsSuccess;

        public Response(string message, bool isSuccess = false)
        {
            Message = message;
            IsSuccess = isSuccess;
        }

        public void WriteMessage()
        {
            Console.WriteLine(Message);
        }
    }
}
