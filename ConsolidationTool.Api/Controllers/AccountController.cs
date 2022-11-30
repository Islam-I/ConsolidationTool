using ConsolidationTool.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using ConsolidationTool.Service.Services.UserManagement;
using ConsolidationTool.Service.Interfaces.UserManagement;

namespace ConsolidationTool.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountServices _accountSerivces;

        public AccountController(IAccountServices accountSerivces)
        {
            _accountSerivces = accountSerivces;
        }

        [HttpPost("AccountRegister")]
        public async Task<IActionResult> AccountRegister(ApplicationUserDto input)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _accountSerivces.Register(input);

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            return Ok("Registered");
        }

        [HttpPost("AccountLogin")]
        public async Task<IActionResult> AccountLogin(ApplicationUserDto input)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _accountSerivces.Login(input);

            if (!result.Succeeded)
            {
                return Unauthorized(input);
            }
            
            return Ok("Singed");
        }
    }
}
