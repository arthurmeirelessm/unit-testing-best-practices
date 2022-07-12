using api_architecture_bestpracties.Helpers;
using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Services
{
    public class UserService : IUserService
    {

        private readonly DataContext _dataContext;

        public UserService(DataContext dataContet)
        {
            _dataContext = dataContet;
        }

        public async Task<UserModel> CreateUserAsync(UserModel user)
        {
            UserModel userDb = await _dataContext.Users.SingleOrDefaultAsync(x => x.Email == user.Email);

            if (userDb is not null)
            {
                throw new System.Exception
            }
            return userDb;  
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
