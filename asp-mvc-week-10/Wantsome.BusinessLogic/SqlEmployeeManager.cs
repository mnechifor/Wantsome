using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wantsome.DataAccess;
using Wantsome.Interfaces;
using Wantsome.Models;

namespace Wantsome.BusinessLogic
{
    public class SqlEmployeeManager : IEmployeeManager
    {
        private EmployeesDatabaseEntities db;

        public SqlEmployeeManager()
        {
            db = new EmployeesDatabaseEntities();
        }
        public void Save(Employee employee)
        {
            db.Employees.Add(employee);
            db.Entry(employee.Grade).State = EntityState.Unchanged;

            db.SaveChanges();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
           return db.Employees.Select(e => e)
               .ToList();
        }
    }
}
