using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using Autofac.Core;
using _05_Application;

namespace _05_MVC.Controllers
{
    public class MyController : Controller
    {
        private IApplication _application;
        IEnumerable<string> aa = new List<string>();
        //
        // GET: /My/
        public ActionResult Index()
        {
            return View();
        }
    }
}