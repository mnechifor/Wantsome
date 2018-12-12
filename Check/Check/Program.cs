using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check
{
    class Program
    {
        public static int FindIndex(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int FindOcccurencies(int[] array, int value)
        {
            int counter = 0;

            foreach (var element in array)
            {
                if (element == value)
                {
                    counter++;
                }
            }

            return counter;
        }

        public static void Main(string[] args)
        {
            int[] arr = new[] { 1, 17, 2, 7, 2, 8 };
            int value = 2;
            int index = 3;

            int[] newArray = new int[arr.Length + 1];

            int counter = 0;

            for (int i = 0; i <= arr.Length; i++)
            {
                if (i == index)
                {
                    newArray[i] = value;
                    counter++;
                }
                else
                {
                    newArray[i] = arr[i - counter];
                }
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }

            Console.ReadLine();
        }

        private static void RemoveElementFromArray()
        {
            int[] arr = new[] {1, 17, 2, 7, 2, 8};
            int value = 2;

            var index = FindIndex(arr, value);

            var occurencies = FindOcccurencies(arr, value);


            int[] newArray = new int[arr.Length - occurencies];

            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    continue;
                }

                newArray[counter] = arr[i];
                counter++;
            }

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
