using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Facades.Strategies
{
    public class UserFacade : IUserFacade
    {


        private readonly IUserService _userService;

        public UserFacade(IUserService userService)
        {
            _userService = userService;
        }

        public Task<UserModel> CreateUserAsync(UserModel user)
        {
            return _userService.CreateUserAsync(user);
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<UserModel>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<UserModel> UpdateByIdAsync(UserModel user, int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
