using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using Flickr.Models;
using Flickr.Controllers;

namespace Flickr.Tests.ControllerTests
{
    public class PhotoControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            PhotoController controller = new PhotoController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            PhotoController controller = new PhotoController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Photo>>(result);
        }
    }
}
