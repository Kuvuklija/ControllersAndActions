using System.Web.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
  public class ExampleController : Controller
  {
    public ViewResult Index()
    {
      //return View("Homepage");
      //return View();
      //return View("Index","_AlternativeLayoutPage");//forcibly to appoint layout for a view Index
      //return View("~/Views/Derived/MyView.cshtml");
      ViewBag.Hi = "Hello";
      ViewBag.Browser = Request==null ? "Fuck": Request.Browser.Browser;
      DateTime date = DateTime.Now;
      return View(date);
    }

    public RedirectResult Redirect() {
      return Redirect("Index");
    }
  }
}
