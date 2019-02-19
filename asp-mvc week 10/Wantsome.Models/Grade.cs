using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wantsome.Models
{
    public class Grade
    {
        public int GradeId { get; set; }

        public string GradeName { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
