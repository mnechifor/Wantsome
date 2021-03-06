﻿using System;
using System.Globalization;
using System.Web.Mvc;
using Wantsome.BusinessLogic;
using Wantsome.Exceptions;
using Wantsome.Interfaces;
using Wantsome.Models;

namespace Wantsome.WebApp01.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeManager _employeesManager;

        private readonly ISqlGradesManager _gradesManager;

        public HomeController()
        {
            _employeesManager = new SqlEmployeeManager();
            _gradesManager = new SqlGradesManager();
        }

        // GET /
        // GET /home/
        // GET /home/index
        public ActionResult Index()
        {
            var employees = _employeesManager.GetAll();
            Session["Grades"] = _gradesManager.GetGrades();

            //Views/Home/Index.cshtml
            return View(employees); //employees - (@model in view)
        }

        // GET /home/details/{id} - id un tip de param (uri param)
        public ActionResult Details(int id)
        {
            var employee = _employeesManager.Get(id);

            //Views/Home/Details.cshtml
            return View(employee); //employee - (@model in view)
        }

        // GET /home/add
        [HttpGet]
        public ActionResult Add(int? id)
        {
            if (id == null) return View();

            var emp = _employeesManager.Get(id.Value);

            //Views/Home/Add.cshtml
            return View(emp);
        }

        // POST /home/add + request body
        [HttpPost]
        public ActionResult Add(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.Grade = _gradesManager.GetGradeById(employee.GradeId);

                try
                {
                    _employeesManager.Save(employee);
                }
                catch (EmployeeContainsALetterException e)
                {
                    Console.WriteLine(e);

                    //ModelState.Add("message", new ModelState
                    //{
                    //    Value = new ValueProviderResult("row", "", CultureInfo.CurrentCulture),
                    //    Errors = { e }
                    //});

                    return View(employee);
                }

                return Redirect("Index");
            }

            //Views/Home/Add.cshtml
            return View(employee);
        }

        //protected override void OnException(ExceptionContext filterContext)
        //{
        //    filterContext.ExceptionHandled = true;

        //    filterContext.Result = new ViewResult
        //    {
        //        ViewName = "~/Views/Error/Index.cshtml"
        //    };
        //}
    }
}