using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplicationIO.Controllers
{
    public class HomeController : Controller
    {
        private readonly IneApplication _iApplication;

        public HomeController(IneApplication iApplication)
        {
            this._iApplication = iApplication;
        }

        public ActionResult Index(IneApplication mode)
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
