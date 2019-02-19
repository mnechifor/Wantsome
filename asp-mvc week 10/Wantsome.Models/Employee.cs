using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wantsome.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [DisplayName("Email address")]
        public string Email { get; set; }

        [DisplayName("Details")]
        public string Details { get; set; }

        public int GradeId { get; set; }

        public virtual Grade Grade { get; set; }
    }
}