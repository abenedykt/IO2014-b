using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC___DI.Controllers
{
    public class EventsController : Controller
    {
        private Application.IApplication _application;

        public EventsController(Application.IApplication application)
        {
            _application = application;
        }
        //
        // GET: /Events/
        public ActionResult Index()
        {
            return View(_application.Events);
        }

        //
        // GET: /Events/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Events/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Events/Create
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
        // GET: /Events/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Events/Edit/5
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
        // GET: /Events/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Events/Delete/5
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
