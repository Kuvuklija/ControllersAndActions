using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
  public class ExampleController : Controller
    {
        public ViewResult Index()
        {
           //return View("Homepage");
           //return View();
           return View("Index","_AlternativeLayoutPage");
        }
    }
}
