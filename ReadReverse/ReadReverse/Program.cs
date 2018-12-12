using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti sirul de caractere:");

            var s = Console.ReadLine();

            var arr = s.ToCharArray();

            for (var i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }

            //Console.WriteLine(s.Reverse());
            Console.ReadLine();
        }
    }
}
