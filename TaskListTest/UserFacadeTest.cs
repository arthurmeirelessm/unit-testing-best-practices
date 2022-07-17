using api_architecture_bestpracties.Facades;
using api_architecture_bestpracties.Facades.Strategies;
using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Shouldly;
using System;
using System.Threading.Tasks;
using Xunit;

namespace TaskListTest
{
    public class UserFacadeTest
    {

        private readonly UserFacade _userFacade;
        private readonly Mock<IUserService> _userServiceMock;

        public UserFacadeTest()
        {
            _userServiceMock = new Mock<IUserService>();
            _userFacade = new UserFacade(_userServiceMock.Object);
        }


        [Fact]
        public async Task GetByIdAsync_ShouldReturnUser_WhenUserExists()
        {
            // Arrange
            var userModel = new UserModel
            {
                FirstName = "Moises",
                LastName = "Carmo",
                Email = "moises@gmail.com",
                UserName = "moisesscarmo",
                Age = 45,
                TypeUser = (api_architecture_bestpracties.Enuns.TypeUser)0,
                Password = "9807",
                Id = 3
            };
            _userServiceMock.Setup(x => x.GetByIdAsync(userModel.Id))
                .ReturnsAsync(userModel);

            // Act
            var response = await _userFacade.GetByIdAsync(userModel.Id);

            //Assert
            Assert.Equal(userModel, response);
         
        }
    }
}
