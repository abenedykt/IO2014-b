using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zajecia3_MVCAngular.Controllers
{
    public class testController : Controller
    {
        //
        // GET: /test/
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetNumbersFromServer(string number)
        {
            int digit = int.Parse(number);
            string[] numbers = new string[digit];
            for (int i = 1; i <= digit; i++)
            {
                if (i % 15 == 0)
                {
                    numbers[i - 1] = "FizzBazz";
                }
                else if (i % 5 == 0)
                {
                    numbers[i - 1] = "Bazz";
                }
                else if (i % 3 == 0)
                {
                    numbers[i - 1] = "Fizz";
                }

                else
                {
                    numbers[i - 1] = i.ToString();
                }
            }
            return Json(numbers, JsonRequestBehavior.AllowGet);
        }

        //
        // GET: /test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /test/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /test/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /test/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /test/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
