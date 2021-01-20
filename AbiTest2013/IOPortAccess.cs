using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiTest2013
{
    class IOPortAccess
    {
        public bool OpenDriver()
        {
            return false;
        }

        public void CloseDriver()
        {

        }

        public int ReadPort(int port)
        {
            return -1;
        }

        public void WritePort(int port, int value)
        {

        }

    }
}
