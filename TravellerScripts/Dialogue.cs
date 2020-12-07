using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TravellerScripts
{
    abstract class Dialogue
    {
        private List<DialogueNode> startNodes;

        public List<DialogueNode> StartNodes { get => startNodes; }

        public void Add(params DialogueNode[] dialogueNodes)
        {
            if (startNodes is null)
                startNodes = new List<DialogueNode>();

            startNodes.AddRange(dialogueNodes);
        }

        public static void CreateFromFile(string path)
        {
            
        }

    }
}
