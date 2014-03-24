using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace FizzBuzz_MVC.Controllers
{
    public class FizzBuzzController : ApiController
    {
        //
        // GET: /FizzBuzz/

        public ActionResult Index()
        {
            return View();
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
