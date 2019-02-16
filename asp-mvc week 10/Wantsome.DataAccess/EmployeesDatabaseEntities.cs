using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Wantsome.Models;

namespace Wantsome.DataAccess
{
    public partial class EmployeesDatabaseEntities : DbContext
    {
        public EmployeesDatabaseEntities()
            : base("name=EmployeesDatabaseEntities")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}