using Microsoft.AspNetCore.Mvc;
using Moq;
using WebAPI.Controllers;

namespace WebAPI.Tests
{
    public class PersonDetailsTesting
    {
        [Fact]
        public void GetPersonDetails_ReturnsOkResult()
        {
            // Arrange
            var controller = new PersonController();

            // Act
            var result = controller.GetPersonDetails();

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetPersonDetails_ReturnsCorrectData()
        {
            // Arrange
            var controller = new PersonController();
            var expectedDetails = new PersonController.PersonDetails
            {
                Id = It.IsAny<string>(),
                Name = "Reynaldo",
                Age = "25"
            };

            // Act
            var result = controller.GetPersonDetails() as OkObjectResult;
            var actualDetails = result?.Value as PersonController.PersonDetails;

            // Assert
            Assert.NotNull(actualDetails);
            Assert.Equal(expectedDetails.Name, actualDetails.Name);
            Assert.Equal(expectedDetails.Age, actualDetails.Age);
        }
    }
}
