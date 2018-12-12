using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            Node node1 = list.AddFirst(1);
            Node node2 = list.AddAfter(node1, 2);
            Node node3 = list.AddAfter(node2, 3);
            Node node4 = list.AddAfter(node3, 4);
            Node node5 = list.AddAfter(node4, 5);

            node5.Next = node2;



            list.Print();

            Console.ReadLine();
        }
    }
}
