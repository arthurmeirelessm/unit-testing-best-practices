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

        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            return await _userService.CreateUserAsync(user);
        }

        public async Task<UserModel> GetByIdAsync(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        public async Task DeleteByIdAsync(int id)
        {
            await _userService.DeleteByIdAsync(id);
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            return await _userService.GetAllAsync();
        }

        public async Task<UserModel> UpdateByIdAsync(UserModel user, int id)
        {
            return await _userService.UpdateByIdAsync(user, id);
        }
    }
}
