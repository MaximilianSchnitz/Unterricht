using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TravellerScripts
{
    class DialogueNode
    {
        //Set if this option can be chosen
        public bool Available { get; set; } = true;

        //The text the other persons says
        public string Message { get; set; }

        //List of child nodes
        public List<DialogueNode> DialogueNodes { get; set; } = new List<DialogueNode>();
        //The texts matching to the dialogue nodes
        public List<string> Responses { get; set; } = new List<string>();

        /// <summary>
        /// Adds the dialogue node and response to the list of child nodes
        /// </summary>
        /// <param name="dialogueNode"></param>
        /// <param name="response"></param>
        public void Add(DialogueNode dialogueNode, string response)
        {
            DialogueNodes.Add(dialogueNode);
            Responses.Add(response);
        }

    }
}
