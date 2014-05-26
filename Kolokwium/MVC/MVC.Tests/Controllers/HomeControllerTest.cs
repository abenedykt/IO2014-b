using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC;
using MVC.Controllers;

namespace MVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TryToThrowExceptionInIndex()
        {
            // Arrange
            HomeController controller = new HomeController(new SomeLongRunningStuff());

            // Act
            ViewResult result = controller.Index() as ViewResult;
        }

        [TestMethod]
        public void CheckIfViewFromIndexIsNotNull()
        {
            // Arrange
            HomeController controller = new HomeController(new WorkingStuff());

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
