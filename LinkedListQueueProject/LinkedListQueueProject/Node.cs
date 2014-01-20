using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListQueueProject
{
    public class Node
    {
        string name;
        Node nextNode;

        public Node()
        {
        }

        public Node(string desiredName)
        {
            name = desiredName;
        }

        public Node(Node desiredNextNode)
        {
            nextNode = desiredNextNode;
        }

        public Node(string desiredName, Node desiredNextNode)
        {
            name = desiredName;
            nextNode = desiredNextNode;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string desiredName)
        {
            name = desiredName;
        }

        public Node GetNextNode()
        {
            return nextNode;
        }

        public void SetNextNode(Node desiredNextNode)
        {
            nextNode = desiredNextNode;
        }
    }
}
