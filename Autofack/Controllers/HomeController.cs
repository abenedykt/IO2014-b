using Autofack.DAL;
using Autofack.Models;
using Autofack.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Autofack.Controllers
{
    public class HomeController : Controller
    {
        private IDAL _dal;
        public HomeController(IDAL dal)
        {
            _dal = dal;
        }

        public ActionResult People()
        {
            return View(new PersonViewModel(_dal.GetPerson()));
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}