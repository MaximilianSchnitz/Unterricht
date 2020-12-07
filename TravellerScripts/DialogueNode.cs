using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellerScripts
{
    class DialogueNode
    {
        private List<DialogueNode> nodes;
        private bool available;

        public List<DialogueNode> Nodes { get => nodes; }
        public bool Available { get => available; set => available = value; }

        public string Message { get; set; }

        public void Add(params DialogueNode[] dialogueNodes)
        {
            if (nodes is null)
                nodes = new List<DialogueNode>();

            nodes.AddRange(dialogueNodes);
        }

        

    }
}
