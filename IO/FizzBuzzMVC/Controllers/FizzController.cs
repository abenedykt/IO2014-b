using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            Game game = new Game();
            
            var lista = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                    lista.Add(game.Say(i));
            }
            
            return PartialView("_FizzBuzz", lista);
        }
        
    }
}
