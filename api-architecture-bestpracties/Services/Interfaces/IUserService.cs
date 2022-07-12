﻿using api_architecture_bestpracties.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserModel> CreateUserAsync(UserModel user);
        Task<UserModel> GetByIdAsync(int id);
        Task<List<UserModel>> GetAllAsync();
        Task<UserModel> UpdateByIdAsync(UserModel user, int id);
        Task DeleteByIdAsync(int id);

    }
}