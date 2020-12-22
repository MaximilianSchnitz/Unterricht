using System;
namespace TravellerScripts
{
    public class DialogueException : Exception
    {
        public DialogueException() : base()
        { }

        public DialogueException(string message) : base(message)
        { }

        public DialogueException(string message, Exception inner) : base(message, inner)
        { }

    }
}
