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

        [HttpPost("users")]
       public async Task<IActionResult> CreateUserAsync([FromBody] UserModel user)
        {
            var methodFacade = await _userFacade.CreateUserAsync(user);

            return Ok(methodFacade);
        } 
    }
}
