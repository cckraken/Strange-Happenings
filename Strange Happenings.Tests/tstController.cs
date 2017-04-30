using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strange_Happenings.Controllers;
using System.Web.Mvc;

namespace Strange_Happenings.Tests2
{



  [TestClass]

    public class HomeControllerTesting

    {

        [TestMethod]

        public void Index()

        {

           

            HomeController controller = new HomeController();



   

            ViewResult result = controller.Index() as ViewResult;


            

            Assert.IsNotNull(result);

        }



        [TestMethod]

        public void About()

        {

            // Arrange

            HomeController controller = new HomeController();



            // Act

            ViewResult result = controller.About() as ViewResult;



            // Assert

            Assert.AreEqual("Description", result.ViewBag.Message);

        }



        [TestMethod]

        public void Contact()

        {

            // Arrange

            HomeController controller = new HomeController();



            // Act

            ViewResult result = controller.Contact() as ViewResult;



            // Assert

            Assert.IsNotNull(result);

        }

    }

}