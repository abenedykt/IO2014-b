using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Prog2;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        private ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        public ViewResult Index()
        {
            _stuff.MakeSomeWork();
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
