using System.Collections.Generic;
using System.Web.Mvc;
using Wantsome.Models;

namespace Wantsome.Interfaces
{
    public interface ISqlGradesManager
    {
        IEnumerable<SelectListItem> GetGrades();

        Grade GetGradeById(int gradeId);
    }
}