using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravellerScripts
{
    class DialogueNode
    {
        public bool Available { get; set; } = true;

        public string Message { get; set; }

        public List<DialogueNode> DialogueNodes { get; set; } = new List<DialogueNode>();
        public List<string> Responses { get; set; } = new List<string>();

        public void Add(DialogueNode dialogueNode, string response)
        {
            DialogueNodes.Add(dialogueNode);
            Responses.Add(response);
        }

    }
}
