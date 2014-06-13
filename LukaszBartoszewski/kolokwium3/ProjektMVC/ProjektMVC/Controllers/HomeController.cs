using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SomeLongRunningStuff.ProjektDrugi;

namespace ProjektMVC.Controllers
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

    }
}