using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerScripts
{
    class Response
    {

        private string message;
        private bool available;

        public string Message { get => message; }
        public bool Available { get => available; set => available = value; }

        public Response(string message)
        {
            this.message = message;
        }

    }
}
