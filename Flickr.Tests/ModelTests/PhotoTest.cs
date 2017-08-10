using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Flickr.Models;
using Xunit;

namespace Flickr.Tests.ModelTests
{
    public class PhotoTest
    {
        [Fact]
        public void GetDescriptionTest()
        {
            //Arrange
            var photo= new Photo();
            photo.Description = "Wash the dog";

            //Act
            var result = photo.Description;

            //Assert
            Assert.Equal("Wash the dog", result);
        }

    }
}
