using ChopUrl;
using ChopUrl.Controllers;
using ChopUrl.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ChopUrl.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();
            string urlToAdd = "https://docs.microsoft.com/en-us/aspnet/mvc/overview";
            // Act
            ViewResult result = controller.Index(urlToAdd) as ViewResult;
            Assert.IsNotNull(result);
            Assert.IsNotNull(((ChopUrl.Models.URL)result.Model).ShortUri);
            Assert.AreEqual(urlToAdd,((ChopUrl.Models.URL)result.Model).LongUri.ToString());
            List<URL> lstURL = new UrlController().GetALLURL();
            Assert.IsNotNull(result.ViewBag.listUrl);
        }

        
    }
}
