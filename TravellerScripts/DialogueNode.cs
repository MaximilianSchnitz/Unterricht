using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravellerScripts
{
    class DialogueNode
    {
        private List<DialogueNode> nodes;

        public List<DialogueNode> Nodes { get => nodes; }
        public bool Available { get; set; } = true;

        public string Message { get; set; }
        public string Response { get; set; }

        public void Add(params DialogueNode[] dialogueNodes)
        {
            if (nodes is null)
                nodes = new List<DialogueNode>();

            nodes.AddRange(dialogueNodes);
        }

    }
}
