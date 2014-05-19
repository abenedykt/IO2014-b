using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly INterface _homeNterface;
        public HomeController(INterface homeNterface)
        {
            _homeNterface = homeNterface;
        }
        public ActionResult Index()
        {
            _homeNterface.Connect("connecion sring");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}