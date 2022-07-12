using api_architecture_bestpracties.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Facades
{
    public interface IUserFacade
    {
        public  Task<UserModel> CreateUserAsync(UserModel user);
        public  Task<UserModel> GetByIdAsync(int id);
        public  Task<List<UserModel>> GetAllAsync();
        public  Task<UserModel> UpdateByIdAsync(UserModel user, int id);
        public  Task DeleteByIdAsync(int id);
    }
}
