using api_architecture_bestpracties.Facades;
using api_architecture_bestpracties.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_architecture_bestpracties.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserFacade _userFacade;

        public UserController(IUserFacade userFacade)
        {
            _userFacade = userFacade;
        }

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="user">User model</param>
        [HttpPost]
        public async Task<IActionResult> CreateUserAsync([FromBody] UserModel user)
        {
            var methodFacade = await _userFacade.CreateUserAsync(user);

            return Ok(methodFacade);
        }

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="id">Id past by user</param>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var methodFacade = await _userFacade.GetByIdAsync(id);

            return Ok(methodFacade);
        }

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>  
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var methodFacade = await _userFacade.GetAllAsync();

            return methodFacade.Any() ? Ok(methodFacade) : NotFound();
        }

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="id">Id past by user</param>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteByIdAsync(int id)
        {
            await _userFacade.DeleteByIdAsync(id);
            return NoContent();
        }

        /// <summary>
        /// search for information from a sodexo card
        /// </summary>
        /// <param name="user">user model</param>
        /// <param name="id">Id past by user</param>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutByIdAsync([FromBody] UserModel user, int id)
        {
            var methodFacade = await _userFacade.UpdateByIdAsync(user, id);

            return Ok(methodFacade);
        }


    }
}
