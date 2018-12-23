using System;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{

  public class DerivedController : Controller{
    
        public ActionResult Index(){
            ViewBag.Message = "Hello from the DerivedController Index method";

      //by redirecting from MyExample controller
      ViewBag.Message = TempData["Message"];
      ViewBag.Date = TempData["Date"];
            return View("DerivedView");
        }

        public ActionResult CustomContextData() {
             string userName = User.Identity.Name;
             string serverName = Server.MachineName;
             string clientIP = Request.UserHostAddress;
             string clientBrowser = Request.Browser.Browser;
             DateTime dateStamp = HttpContext.Timestamp;

             ViewBag.clientBrowser = clientBrowser;
             ViewBag.clientIP = clientIP;
             ViewBag.server = Server.MachineName;

             string oldProductName = Request.Form["OldName"];
             string newProductName = Request.Form["NewName"];
             return View((object)clientIP);
        }

        //public void ProduceOutput() {
        public ActionResult ProduceOutput() { 
            if (Server.MachineName == "Horizont") {
              //Response.Redirect("/Basic/Index");
              //return new CustomRedirectResult { Url = "/Basic/Index" };
              //return new RedirectResult("/Basic/Index");
              return Redirect("/Basic/Index");
            }else{
                Response.Write("Controller: "+RouteData.Values["contoller"]+" Action: "+ RouteData.Values["action"]);
                return null;
            }
    }
    }
}
