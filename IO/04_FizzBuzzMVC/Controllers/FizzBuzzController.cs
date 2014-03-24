using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _01_TDD2;
using _04_FizzBuzzMVC.Models;

namespace _04_FizzBuzzMVC.Controllers
{
    public class FizzBuzzController : Controller
    {
        //
        // GET: /FizzBuzz/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /FizzBuzz/Details/5
        public ActionResult GetValues(string value)
        {
            int val;
            if (!int.TryParse(value, out val))
                return View(new List<Value>());

            var game = new Game();

            var tab = new List<Value>();
            for (int i = 1; i <= val; i++)
            {
                tab.Add(game.Say(i));
            }

            return View(tab);
        }

        public string[] GetStringValues(string value)
        {
            int val;
            if (!int.TryParse(value, out val))
                return new string[0];

            var game = new Game();

            var tab = new List<string>();
            for (int i = 1; i <= val; i++)
            {
                tab.Add(game.Say(i).Number.ToString());
            }

            return tab.ToArray();
        }
    }
}
