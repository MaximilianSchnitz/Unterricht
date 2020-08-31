using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_Test
{
    class Alarm
    {
        private bool status;

        public void TurnOn()
        {
            status = false;
        }

        public void TurnOff()
        {
            status = false;
        }

        public bool IsSirenOn()
        {
            return status;
        }

    }
}
