using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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

             string oldProductName = Request.Form["OldName"];
             string newProductName = Request.Form["NewName"];
             return View((object)clientIP);
        }
    }
}
