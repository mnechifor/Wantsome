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

        public virtual DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().
                HasMany(e => e.Employees);

            modelBuilder.Entity<Employee>()
                .HasRequired(e => e.Grade)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.GradeId);
        }
    }
}