using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Student : Human, IHumanBehaviour
    {
        public int Grade { get; set; }

        public Student()
        {
            
        }

        public void Walk(string direction)
        {
            
        }
    }
}
