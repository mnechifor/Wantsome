using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public Employee Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Employee> GetAll()
        {
           return db.Employees.Select(e => e).ToList();
        }
    }
}
