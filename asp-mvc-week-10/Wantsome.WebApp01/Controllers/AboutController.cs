using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Wantsome.WebApp01.Controllers
{
    public class AboutController : Controller
    {
        //site/about/
        //site/about/index
        public ActionResult Index()
        {
            //Views/About/Index.html
            return View();
        }
    }
}