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
          ExampleController target = new ExampleController();
          //action
          ViewResult result = target.Index();
      //assert
      //Assert.AreEqual("Homepage", result.ViewName); //if ViewResult("Homepage")
      //Assert.AreEqual("", result.ViewName);          //if ViewResult()
      //Assert.AreEqual("~/Views/Derived/MyView.cshtml", result.ViewName);      //if ViewResult("~/Views/Derived/MyView")
      Assert.AreEqual("", result.ViewName);
      Assert.IsInstanceOfType(result.ViewData.Model, typeof(System.DateTime));
      Assert.AreEqual("Hello",result.ViewBag.Hi);
        }
    }
}
