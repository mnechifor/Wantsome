using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker s = new Worker(10, 10);
            List<IHumanBehaviour> list = new List<IHumanBehaviour>();

            list.Add(new Student());
            list.Add(s);

            foreach (IHumanBehaviour human in list)
            {
            }

            Console.ReadLine();

            
        }
    }
}
