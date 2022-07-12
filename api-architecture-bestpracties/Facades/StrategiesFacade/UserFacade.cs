﻿using api_architecture_bestpracties.Models;
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

        public Task DeleteByIdAsync(int id)
        {
            return _userService.DeleteByIdAsync(id);
        }

        public Task<List<UserModel>> GetAllAsync()
        {
           return _userService.GetAllAsync();
        }

        public Task<UserModel> GetByIdAsync(int id)
        {
            return _userService.GetByIdAsync(id);
        }

        public Task<UserModel> UpdateByIdAsync(UserModel user, int id)
        {
           return _userService.UpdateByIdAsync(user, id);
        }
    }
}