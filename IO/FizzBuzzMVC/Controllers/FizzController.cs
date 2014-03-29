using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FizzBuzzMVC.Models;

namespace FizzBuzzMVC.Controllers
{
    public class FizzController : Controller
    {
        //
        // GET: /Fizz/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Fizz/Details/5
        [HttpPost]
        public ActionResult FizzBuzz(int p)
        {
            var lista = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                if (i == 0) lista.Add(i.ToString());
                else if (i % 5 == 0)
                    lista.Add(i%3 == 0 ? "FizzBuzz" : "Buzz");
                else if (i % 3 == 0)
                    lista.Add("Fizz");
                else
                lista.Add(i.ToString());
            }
            
            return PartialView("_FizzBuzz", lista);
        }
        
    }
}
