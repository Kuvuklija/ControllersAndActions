using System.Web.Mvc;
using System;

namespace ControllersAndActions.Controllers
{
  public class MyExampleController : Controller
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

    //public RedirectResult Redirect() {
      //return Redirect("Index");
      //return RedirectPermanent("Index");

    public RedirectToRouteResult Redirect() {
      //return RedirectToRoute(new{
      //  controller = "MyExample",
      //  action = "Index",
      //  id = "MyId"});
      TempData["Message"] = "Hello";
      TempData["Date"] = DateTime.Now;
      TempData["DirectlyToView"] = "Fuck you!";
      return RedirectToAction("Index", "Derived");
    }

    public HttpStatusCodeResult StatusCode() {
      //return new HttpStatusCodeResult(404, "Url cannot be serviced"); 
      //return HttpNotFound(); //the same as above

      return new HttpUnauthorizedResult();
    }
  }
}
