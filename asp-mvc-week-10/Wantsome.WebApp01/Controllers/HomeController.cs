using System;
using System.Web.Mvc;
using Wantsome.BusinessLogic;
using Wantsome.Interfaces;
using Wantsome.Models;

namespace Wantsome.WebApp01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeManager employeesManager;
        private readonly ISqlGradesManager gradesManager;

        public HomeController()
        {
            employeesManager = new SqlEmployeeManager();
            gradesManager = new SqlGradesManager();

            ViewBag.CurrentUserName = "Andrei";
            ViewData["CurrentUserName2"] = "Andrei 2";
            TempData["TempDataKey"] = "123";
        }

        // GET /
        // GET /home/
        // GET /home/index
        public ActionResult Index()
        {
            var employees = employeesManager.GetAll();
            Session["Grades"] = gradesManager.GetGrades();

            //Views/Home/Index.cshtml
            return View(employees); //employees - (@model in view)
        }

        // GET /home/details/{id} - id un tip de param (uri param)
        public ActionResult Details(int id)
        {
            var employee = employeesManager.Get(id);

            //Views/Home/Details.cshtml
            return View(employee); //employee - (@model in view)
        }

        // GET /home/add
        [HttpGet]
        public ActionResult Add(int? id)
        {
            if (id == null) return View();

            var emp = employeesManager.Get(id.Value);

            //Views/Home/Add.cshtml
            return View(emp);
        }

        // POST /home/add + request body
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Grade = gradesManager.GetGradeById(employee.GradeId);

                employeesManager.Save(employee);

                return Redirect("Index");
            }

            //Views/Home/Add.cshtml
            return View(employee);
        }
    }
}