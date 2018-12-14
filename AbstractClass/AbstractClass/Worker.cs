using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Worker : Human, IHumanBehaviour
    {
        public Worker(decimal weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary { get; set; }

        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return WeekSalary / 7 / WorkHoursPerDay;
        }

        public void Walk(string direction)
        {
            
        }
    }
}
