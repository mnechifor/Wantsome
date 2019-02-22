using System.Collections.Generic;
using Wantsome.Models;

namespace Wantsome.Interfaces
{
    public interface IEmployeeManager
    {
        void Save(Employee employee);

        Employee Get(int id);

        IList<Employee> GetAll();
    }
}