using System.Web.Mvc;

namespace AspectsTest.Controllers
{
    public class TestController : Controller
    {
        private IFakeRepository _fakeRepo;

        public TestController(IFakeRepository fakeRepo)
        {
            _fakeRepo = fakeRepo;
        }

        public ActionResult Index()
        {
            return Json(_fakeRepo.GetSingleEntry(), JsonRequestBehavior.AllowGet);
        }
    }
}