using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SingleLinkedList
    {
        private Node First;
        public Node AddFirst(int value)
        {
            Node node = new Node();
            node.Value = value;
            node.Next = null;

            First = node;

            return node;
        }
        public Node AddAfter(Node node, int val)
        {
            Node newNode = new Node();
            newNode.Value = val;

            node.Next = newNode;

            return newNode;
        }

        public bool DedectCycle()
        {
            //TODO: Homework


        }

        public void Print()
        {
            Node currentNode = First;

            while (currentNode != null)
            {
                Console.Write(currentNode.Value + " ");

                currentNode = currentNode.Next;
            }
        }
    }
}
