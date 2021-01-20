using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class Drucker
    {
        int port;

        public Drucker(int port)
        {
            this.port = port;
        }

        public void Close()
        {
            port = -1;
        }

        public void DruckeZeichen(char zeichen)
        {
            if(port > 0)
                Console.Write(zeichen);
        }

        public bool Open()
        {
            return port > 0;
        }

    }
}
