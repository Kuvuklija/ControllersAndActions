using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ControllersAndActions.Infrastructure;

namespace ControllersAndActions.Controllers{

    public class DerivedController : Controller{
    
        public ActionResult Index(){
            ViewBag.Message = "Hello from the DerivedController Index method";
            return View("MyView");
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
            if (Server.MachineName == "LAPTOP-CLK2NFEV") {
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
