using System;
using System.Collections.Generic;

namespace InfiniteConvergentSeries
{
/*
     By using delegates develop an universal static method to calculate the sum of infinite convergent
     series with given precision depending on a function of its term.By using proper functions for the term
     calculate with a 2-digit precision the sum of the infinite series:
        1 + 1/2 + 1/4 + 1/8 + 1/16 + …
        1 + 1/2! + 1/3! + 1/4! + 1/5! + …
        1 + 1/2 - 1/4 + 1/8 - 1/16 + …
*/
    class Program
    {
        public delegate double CalculateTerm(int term);

        static double FirstSeriesTerm(int term)
        {
            return 1.0 / Math.Pow(term, 2);
        }

        static double SecondSeriesTerm(int term)
        {
            return 1.0 / Factorial(term);
        }

        static double ThirdSeriesTerm(int term)
        {
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            CalculateSeries(FirstSeriesTerm);

            CalculateSeries(SecondSeriesTerm);

            Console.ReadLine();
        }

        private static void CalculateSeries(CalculateTerm termCompute)
        {
            foreach (var partialSum in GetPartialSum(100000, termCompute))
            {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(partialSum);
            }
        }

        private static IEnumerable<double> GetPartialSum(int n, CalculateTerm termCompute)
        {
            double sum = 0.0;
            for (int i = 1; i <= n; i++)
            {
                sum += termCompute(i);
                yield return sum;
            }
        }

        private static int Factorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
