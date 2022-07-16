using Xunit;
using Moq;
using Tweetinvi.Core.Controllers;
using api_architecture_bestpracties.Controllers;
using api_architecture_bestpracties.Facades;

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



    }
}
