using System.Reflection;
using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class MainController : Controller
    {
        //
        // GET: /Main/

        public ActionResult Index()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();

            builder.RegisterModule(new AutofacWebTypesModule());
            builder.RegisterSource(new ViewRegistrationSource());

            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.Register(c => new Logger("asdf")).As<ILogger>().InstancePerHttpRequest();
            builder.RegisterFilterProvider();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            return View();
        }

        //
        // GET: /Main/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Main/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Main/Create

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
        // GET: /Main/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Main/Edit/5

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
        // GET: /Main/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Main/Delete/5

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
