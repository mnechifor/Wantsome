using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] {10, 5, 7, 1, 9};

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        Swap(arr, i, j);
                    }
                }
            }

            foreach (var el in arr)
            {
                Console.Write(el + " ");
            }

            Console.ReadLine();
        }

        private static void Swap(int[] arr, int x, int y)
        {
            int aux;
            aux = arr[x];
            arr[x] = arr[y];
            arr[y] = aux;
        }

        private static void RemoveElementFromList()
        {
            //Write code to remove duplicates from an unsorted linked list.
            var list = InitList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    var firstEl = list.ElementAt(i);
                    var secondEl = list.ElementAt(j);

                    if (firstEl == secondEl)
                    {
                        list.Remove(firstEl);
                    }
                }
            }

            DisplayList(list);

            Console.ReadLine();
        }

        private static void DisplayList(LinkedList<int> list)
        {
            foreach (var node in list)
            {
                Console.Write(node + " ");
            }
        }

        private static LinkedList<int> InitList()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(10);
            list.AddAfter(list.First, 20);
            list.AddLast(30);
            list.AddLast(30);
            list.AddLast(50);
            return list;
        }

        private static void Reverse()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            // arr = ReverseArray(arr);
            Array.Reverse(arr);

            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }

            Array.Reverse(arr);

            Console.ReadLine();
        }

        public static int[] ReverseArray(int[] arr)
        {
            int[] reversedArray = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reversedArray[i] = arr[arr.Length - 1 - i];
            }

            return reversedArray;
        }

        public static double Div(int no1, int no2)
        {
            if (no2 != 0)
            {
                return no1 / (double)no2;
            }
            else
            {
                Console.WriteLine("Cannot divide by 0");
            }

            return -1;
        }
    }
}
