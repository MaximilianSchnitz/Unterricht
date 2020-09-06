using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_Test
{
    class Door
    {
        private bool locked;

        private int roomNumber;

        public Door(int roomNumber)
        {
            this.roomNumber = roomNumber;
        }

        public int GetRoomNumber()
        {
            return roomNumber;
        }

        public bool IsLocked()
        {
            return locked;
        }

        public bool IsUnlocked()
        {
            return !locked;
        }

        public void UnlockDoor()
        {
            locked = false;
        }

        public void LockDoor()
        {
            locked = true;
        }



    }
}
