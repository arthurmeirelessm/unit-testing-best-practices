using api_architecture_bestpracties.Helpers;
using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
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
            UserModel userDb = await _dataContext.Users.AsNoTracking().SingleOrDefaultAsync(x => x.UserName == user.UserName);

            if (userDb is not null)
            {
                throw new Exception($"User {user.UserName} already exists");
            }

            _dataContext.Users.Add(user);
            await _dataContext.SaveChangesAsync();

            return user;
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
