using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOS_Test
{
    class Display
    {

        private String message;
        private int fontSize;

        public Display()
        { }

        public String GetMessage()
        {
            return message;
        }

        public void SetMessage(String message)
        {
            this.message = message;
            Console.WriteLine(message);
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public void SetFontSize(int fontSize)
        {
            this.fontSize = fontSize;
        }

    }
}
