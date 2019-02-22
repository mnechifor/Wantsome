using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Wantsome.DataAccess;
using Wantsome.Interfaces;
using Wantsome.Models;

namespace Wantsome.BusinessLogic
{
    public class SqlGradesManager : ISqlGradesManager
    {
        private readonly EmployeesDatabaseEntities _db;

        public SqlGradesManager()
        {
            _db = new EmployeesDatabaseEntities();
        }

        public IEnumerable<SelectListItem> GetGrades()
        {
            var grades = _db.Grades.Select(g => g);

            var gradesList = new List<SelectListItem>();

            foreach (var grade in grades)
            {
                gradesList.Add(new SelectListItem
                {
                    Value = grade.GradeId.ToString(),
                    Text = grade.GradeName
                });
            }

            return gradesList;
        }

        public Grade GetGradeById(int gradeId)
        {
            var grade = _db.Grades.First(g => g.GradeId == gradeId);

            return grade;
        }
    }
}