using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p1 = new Professor
                {
                    Name = "Name",
                    Faculty = "Info",
                    Specialization = "Info"
                };

            var str = p1.Print();

            Console.WriteLine(str);

            Student s1 = new Student("Ionut", "Info", 2010);

            Console.ReadLine();
        }
    }
}
