using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Method2(i);

            
        }

        static void Method2(int i)
        {
            i = 8;
        }

        static void Method(out int i)
        {
            i = 8;
        }
    }

    class Author
    {
        
    }
}
