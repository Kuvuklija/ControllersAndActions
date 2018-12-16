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
         //Assert.AreEqual("Homepage", result.ViewName);
          Assert.AreEqual("", result.ViewName);
        }
    }
}
