using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FizzBuzz_MVC.Models;

namespace FizzBuzz_MVC.Controllers
{
    public class FizzBuzzController : ApiController
    {
        private int number;

        // GET api/fizzbuzz
        public IEnumerable<string> Get()
        {
            var game = new Game(5);
            return game.FizzBuzz;
        }

        // POST api/fizzbuzz
        public void Post(Object number)
        {
            this.number = Convert.ToInt32(number);
        }
    }
}
