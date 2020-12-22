using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace TravellerScripts
{
    class Dialogue
    {
        private DialogueNode startNode;
        public DialogueNode StartNode { get => startNode; }

        public int ID { get; set; }

        public void CreateFromFile(string path, int personId)
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

            startNode = CreateDialogueNodeTreeFromXml(person, 0);
        }

        private DialogueNode CreateDialogueNodeTreeFromXml(XmlNode personXmlNode, int currentDialogueXmlNode)
        {
            var dialogueNode = new DialogueNode();

            //Gets child nodes from current person node
            var dialogueXmlNodes = personXmlNode.ChildNodes;

            var dialogueXmlNode = dialogueXmlNodes[currentDialogueXmlNode];

            //Get message and responses nodes
            var messageNode = dialogueXmlNode.ChildNodes.Item(0);
            var responsesNode = dialogueXmlNode.ChildNodes.Item(1);

            //Array of all response nodes
            var responseNodes = responsesNode.ChildNodes;

            //Amount of response options
            int responseCount = responseNodes.Count;


            //Set message
            dialogueNode.Message = messageNode.InnerText.Trim();


            //Loop through every response and set them
            for (int i = 0; i < responseCount; i++)
            {
                int reference = int.Parse(responseNodes[i].Attributes["d_ref"].Value);
                string response = responseNodes[i].InnerText;
                if (response != null)
                    response = response.Trim();
                dialogueNode.Add(CreateDialogueNodeTreeFromXml(personXmlNode, reference), response);
            }

            return dialogueNode;
        }
    }
}
