using Application;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IAplication;

namespace MVC.Controllers
{
    public class AplicationController : Controller
    {
        //
        // GET: /Aplication/
        
        public ActionResult Index(IApplication Iapplication)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SomeType>().As<IApplication>();
            return View();
        }

        //
        // GET: /Aplication/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Aplication/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Aplication/Create

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
        // GET: /Aplication/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Aplication/Edit/5

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
        // GET: /Aplication/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Aplication/Delete/5

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
