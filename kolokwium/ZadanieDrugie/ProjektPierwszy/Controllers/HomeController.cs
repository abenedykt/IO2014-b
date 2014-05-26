using ProjektDrugi;
using System.Web.Mvc;

namespace ProjektPierwszy.Controllers
{
    public class HomeController : Controller
    {
        private ISomeStuff _stuff;

        public HomeController(ISomeStuff stuff)
        {
            _stuff = stuff;
        }

        public ActionResult Index()
        {
            _stuff.MakeSomeWork();
            return View();
        }
    }
}