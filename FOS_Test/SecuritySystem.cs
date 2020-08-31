using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_Test
{
    class SecuritySystem
    {

        private List<Door> doors = new List<Door>();
        private Alarm alarm;
        private Display display;

        public SecuritySystem()
        {
            alarm = new Alarm();
            display = new Display();

            int doorLength = 15;

            for (int i = 0; i < doorLength; i++)
                doors[i] = new Door(i);

            if (display.GetFontSize() != 30)
                display.SetFontSize(30);
        }

        public Door FindDoor(int i)
        {
            return doors[i];
        }

        public void ActivateFireAlarm()
        {
            alarm.TurnOn();

            foreach (var d in doors)
                d.UnlockDoor();
        }
        
        public void CheckDoors()
        {
            var lockedDoors = new List<Door>();
            foreach(var d in doors)
                if(d.IsLocked())
                    lockedDoors.Add(d);

            String s = "Die Tore sind verriegelt ";

            String[] array = new String[lockedDoors.Count];
            for (int i = 0; i < array.Length; i++)
                array[i] = lockedDoors[i].GetRoomNumber().ToString();


        }

    }
}
