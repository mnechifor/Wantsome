using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberToGuess = new Random().Next(1, 10);

            while (true)
            {
                Console.WriteLine("Introduceti un numar: ");

                var x = Convert.ToInt32(Console.ReadLine());

                if (x == numberToGuess)
                {
                    Console.WriteLine("Felicitari! Ati ghicit numarul.");
                    break;
                }

                Console.WriteLine((x < numberToGuess)
                    ? "Numarul introdus este prea mic!"
                    : "Numarul introdus este prea mare!");
            }

            Console.ReadLine();
        }
    }
}
