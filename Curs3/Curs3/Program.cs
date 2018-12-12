using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs3
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 16; i <= 97; i += 2)
            //{
            //    Console.WriteLine(i);
            //}

            //for (var i = 20; i <= 65; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            for (var i = 1400; i <= 2300; i++)
            {
                if ((i % 7 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }




        private static void SwapArays()
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 11;
            numbers[2] = 13;
            numbers[3] = 14;
            numbers[4] = 15;

            int x;

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                Swap(numbers, i, numbers.Length - i - 1);
            }

            WriteNumbers(numbers);

            Console.ReadLine();
        }

        public static void Swap(int[] arr, int i, int j)
        {
            var x = arr[i];
            arr[i] = arr[j];
            arr[j] = x;
        }

        public static void WriteNumbers(int[] aux)
        {
            for (int i = 0; i <= aux.Length - 1; i++)
            {
                if (i == aux.Length - 1)
                {
                    Console.Write(aux[i]);
                }
                else
                {
                    Console.Write(aux[i] + ",");
                }
            }
        }
    }
}
