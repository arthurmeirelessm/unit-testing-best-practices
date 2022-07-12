using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Services
{
    public class UserService : IUserService
    {
        public Task<UserModel> CreateUserAsync(UserModel user)
        {
            throw new System.NotImplementedException();
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
