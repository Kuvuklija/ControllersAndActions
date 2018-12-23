using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllersAndActions.Controllers;
using System.Web.Mvc;

namespace ControllersAndActions.Tests
{
  [TestClass]
    public class ActionTests
  {
        [TestMethod]
        public void ControllerTest()
        {
          //arrange
          MyExampleController target = new MyExampleController();
      //action
      //ViewResult result = target.Index();
      //assert
      //Assert.AreEqual("Homepage", result.ViewName); //if ViewResult("Homepage")
      //Assert.AreEqual("", result.ViewName);          //if ViewResult()
      //Assert.AreEqual("~/Views/Derived/MyView.cshtml", result.ViewName);      //if ViewResult("~/Views/Derived/MyView")
      //Assert.AreEqual("", result.ViewName);
      //Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
      //Assert.AreEqual("Hello",result.ViewBag.Hi);

      //RedirectResult result = target.Redirect();
      //Assert.IsTrue(result.Permanent);
      //Assert.AreEqual("Index", result.Url);

      //RedirectToRouteResult result = target.Redirect();

      //Assert.IsFalse(result.Permanent);
      //Assert.AreEqual("MyExample", result.RouteValues["conroller"]);
      //Assert.AreEqual("Index", result.RouteValues["action"]);
      //Assert.AreEqual("MyId", result.RouteValues["id"]);


      HttpStatusCodeResult result_2 = target.StatusCode();
      Assert.AreEqual(401, result_2.StatusCode);


        }
    }
}
