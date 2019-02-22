using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Wantsome.Models
{
    public class Grade
    {
        [Key] public int GradeId { get; set; }

        public string GradeName { get; set; }

        public string Description { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}