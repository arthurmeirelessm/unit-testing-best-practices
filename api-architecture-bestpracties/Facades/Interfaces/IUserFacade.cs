using api_architecture_bestpracties.Models;
using api_architecture_bestpracties.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Facades
{
    public interface IUserFacade
    {
        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="user">User model</param>
        Task<UserModel> CreateUserAsync(UserModel user);

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="id">Id past by user</param>
        Task<UserModel> GetByIdAsync(int id);

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        Task<List<UserModel>> GetAllAsync();

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="user">User model</param>
        /// <param name="id">Id past by user</param>
        Task<UserModel> UpdateByIdAsync(UserModel user, int id);

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="id">Id past by user</param>
        Task DeleteByIdAsync(int id);
    }
}
