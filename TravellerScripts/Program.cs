using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TravellerScripts
{
    class Program
    {
        static void Main(string[] args)
        {
            var dialogue = new Dialogue();
            dialogue.CreateFromXml("/home/felixwagner/Desktop/XmlTestFile.xml", 0);

            PrintDialogueNodes(dialogue.StartNode);
        }

        static void PrintDialogueNodes(DialogueNode startNode)
        {
            var dialogueNode = startNode;

            Console.WriteLine($"Message: {dialogueNode.Message}");

            var responses = dialogueNode.Responses;
            if (responses != null)
                foreach (string s in responses)
                    Console.WriteLine($"Response: {s}");

            for(int i = 0; i < dialogueNode.DialogueNodes.Count; i++)
            {
                PrintDialogueNodes(dialogueNode.DialogueNodes[i]);
            }
        }

    }
}
