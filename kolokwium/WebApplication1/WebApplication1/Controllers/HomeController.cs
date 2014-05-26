using App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ISomeStuff stuff { get; set; }

        public HomeController(ISomeStuff stuff)
        {
            this.stuff = stuff;
        }
        public ActionResult Index()
        {
            stuff.MakeSomeWork();
            return View();
        }

    }
}