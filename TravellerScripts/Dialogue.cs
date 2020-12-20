using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TravellerScripts
{
    abstract class Dialogue
    {
        private DialogueNode startNode;

        public DialogueNode StartNode { get => startNode; }

        public int ID { get; set; }

        public static void CreateFromFile(string path, int personId)
        {
            //Load Xml file
            var xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            //Main Node
            var dialoguesNode = xmlDocument.DocumentElement.SelectSingleNode("/Dialogues");

            //Get node for specific person
            var person = (from XmlNode node in dialoguesNode.SelectNodes("Person")
                          where int.Parse(node.Attributes["id"].Value) == personId
                          select node).FirstOrDefault();

            

            //Loop through every Dialogue node
            var running = true;

            while(running)
            {

            }
        }

        private DialogueNode CreateDialogueNodeTree(XmlNode dialogueNode)
        {
            var dialogue = new DialogueNode();

            //Gets child nodes from current dialogue node
            //Index 0 is always the message, the remaining indicies are always responses
            var childNodes = dialogueNode.ChildNodes;

            var messageNode = childNodes.Item(0);
            var responsesNode = childNodes.Item(1);

            int responseCount = responsesNode.ChildNodes.Count;

            dialogue.Message = messageNode.Value;

            for (int j = 0; j < responseCount; j++)
            {
                
            }


            return dialogue;
        }

    }
}
