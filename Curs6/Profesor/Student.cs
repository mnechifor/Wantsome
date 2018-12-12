using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    class Student
    {
        public string Name { get; }

        public string Faculty { get; }

        public int Year { get; }

        public Student(string Name, string Faculty, int year)
        {
            this.Name = Name;
            this.Faculty = Faculty;
            this.Year = year;
        }
    }
}
