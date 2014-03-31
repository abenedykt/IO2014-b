using System.Web.Mvc;

namespace MVC_Application.Controllers
{
    public class EventsController : Controller
    {
        private IApplication.IApplication _application;
        public EventsController(IApplication.IApplication application)
        {
            _application = application;
        }
        public ActionResult Index()
        {
            return View(_application.Events);
        }
    }
}