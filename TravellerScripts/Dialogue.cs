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
        private DialogueNode currentNode;

        public DialogueNode StartNode { get => startNode; }
        public DialogueNode CurrentNode { get => CurrentNode; }

        /// <summary>
        /// Moves to the next dialogue node at the specified position at returns the node. Starts at position -1.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public DialogueNode Next(int option)
        {
            //On first call set current node to start node
            if (currentNode is null)
                currentNode = startNode;

            //Throws exception if an option is chosen that doesn't exist
            if (option >= currentNode.DialogueNodes.Count)
                throw new DialogueException($"Response option {option} does not exist!");

            currentNode = currentNode.DialogueNodes[option];
            return currentNode;
        }

        /// <summary>
        /// Creates a dialogue tree from an XML file.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="personId"></param>
        public void CreateFromXml(string path, int personId)
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
                //Dialogue reference id
                int reference = int.Parse(responseNodes[i].Attributes["d_ref"].Value);

                //Get response
                string response = responseNodes[i].InnerText;

                //If there is a response, remove whitespaces and the beginning and end
                if (response != null)
                    response = response.Trim();

                //Add response to dialogue node and use recursion to determine the nodes below
                dialogueNode.Add(CreateDialogueNodeTreeFromXml(personXmlNode, reference), response);
            }

            return dialogueNode;
        }
    }
}
