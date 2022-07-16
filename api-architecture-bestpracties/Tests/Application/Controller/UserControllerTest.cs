using Xunit;
using Moq;
using Tweetinvi.Core.Controllers;
using api_architecture_bestpracties.Controllers;
using api_architecture_bestpracties.Facades;
using System.Threading.Tasks;
using api_architecture_bestpracties.Enuns;
using api_architecture_bestpracties.Models;

namespace api_architecture_bestpracties.Tests.Application.Controller

{
    public class UserControllerTest
    {

        private readonly UserController _userController;
        private readonly Mock<IUserFacade> _userfacade;

        public UserControllerTest(UserController userController, Mock<IUserFacade> userfacade)
        {
            _userfacade = new Mock<IUserFacade>();
            _userController = new UserController(_userfacade.Object);
        }



        [Theory]
        [InlineData("Marconi", "Sousa", "marconisousa@gmail.com", "marconisousaa", 38, TypeUser.SofwareEngineer , "6784" )]
        public async Task CreateUserConfirmShouldBeReturnMessageOkAsync(string firstName, string lastName, string email, string userName, int age, TypeUser typeUser, string password)
        {
            //Arrange

            //Act

            //Assert
        }

    }
}
