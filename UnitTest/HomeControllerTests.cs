using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using WebApplication.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace UnitTest
{
    public class HomeControllerTests
    {
        public HomeControllerTests()
        {
        }

        [Fact(DisplayName = "Index should return default view")]
        public void Index_should_return_default_view()
        {
            var controller = new HomeController();
            var viewResult = (ViewResult)controller.Index();
            var viewName = viewResult.ViewName;

            Assert.True(string.IsNullOrEmpty(viewName) || viewName == "Index");
        }

        //[Fact(DisplayName = "Failing test")]
        //public void ShouldFail()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
