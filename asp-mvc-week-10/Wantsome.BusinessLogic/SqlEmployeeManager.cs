using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Wantsome.DataAccess;
using Wantsome.Exceptions;
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
            if (employee.Name.Contains("A"))
            {
                throw new Exception();
            }

            db.Employees.Add(employee);
            db.Entry(employee.Grade).State = EntityState.Unchanged;

            //throw new InvalidOperationException("SQL Server Error");
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
