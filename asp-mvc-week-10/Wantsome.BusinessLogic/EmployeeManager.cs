using System.Collections.Generic;
using Wantsome.Interfaces;
using Wantsome.Models;

namespace Wantsome.BusinessLogic
{
    public class EmployeeManager : IEmployeeManager
    {
        static readonly List<Employee> List = new List<Employee>();

        static int _count = 0;

        public void Save(Employee employee)
        {
            employee.Id = _count++;
            List.Add(employee);
        }

        public Employee Get(int id)
        {
            foreach (var employee in List)
                if (employee.Id == id)
                    return employee;

            return null;
        }

        public IList<Employee> GetAll()
        {
            return List;
        }
    }
}