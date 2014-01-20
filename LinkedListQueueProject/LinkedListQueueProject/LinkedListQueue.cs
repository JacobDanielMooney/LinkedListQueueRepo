using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListQueueProject
{
    public class LinkedListQueue
    {
        private Node headNode;
        private Node tailNode;

        public void Enqueue(Node newNode)
        {
            newNode.SetNextNode(tailNode);
            tailNode = newNode;
            if (tailNode.GetNextNode() == null)
            {
                headNode = tailNode;
            }
        }

        public Node Dequeue()
        {
            Node temporaryNode = headNode;
            headNode = FindNextHeadNode(tailNode);
            return temporaryNode;
        }

        public Node Tail()
        {
            return tailNode;
        }

        public Node Head()
        {
            return headNode;
        }

        public Node Find(string data)
        {
            return FindNodeByData(tailNode, data);
        }

        private Node FindNodeByData(Node currentlySearchingNode, string data)
        {
            if (currentlySearchingNode.GetName() == data)
            {
                return currentlySearchingNode;
            }
            else if (currentlySearchingNode.GetNextNode() != null)
            {
                return FindNodeByData(currentlySearchingNode.GetNextNode(), data);
            }
            return null;
            // Recusion here is not ideal, due to the fact that, for a sufficiently large queue, this recursive loop will blow the stack
        }

        private Node FindNextHeadNode(Node currentlySearchingNode)
        {
            Node currentNode = tailNode;
            Node nextNode;
            while (currentNode != null)
            {
                if (currentNode.GetNextNode() == headNode)
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.GetNextNode();
                }
            }
            return null;
        }
    }
}
