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


        public async Task<UserModel> GetByIdAsync(int id)
        {
            UserModel userDb = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == id);

            if (userDb is null)
            {
                throw new Exception($"Is {id} not exists");
            }
            return userDb;

        }

        public async Task DeleteByIdAsync(int id)
        {
            var userDb = await _dataContext.Users.SingleOrDefaultAsync(x => x.Id == id);

            if (userDb is null)
            {
                throw new Exception($"Is {id} not exists");
            }

            _dataContext.Users.Remove(userDb);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<List<UserModel>> GetAllAsync()
        {
            return await _dataContext.Users.ToListAsync();
        }


        public async Task<UserModel> UpdateByIdAsync(UserModel user, int id)
        {

            UserModel userDb = await _dataContext.Users.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id);

            if (userDb is null)
            {
                throw new Exception($"Is {id} not exists");
            }

            if (user.Id != id)
            {
                throw new Exception($"Is {id} is different");
            }

            _dataContext.Entry(user).State = EntityState.Modified;
            await _dataContext.SaveChangesAsync();

            return user;
        }
    }
}
