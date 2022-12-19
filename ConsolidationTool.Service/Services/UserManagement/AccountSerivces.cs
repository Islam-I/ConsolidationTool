using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.DBModels;
using ConsolidationTool.Service.Interfaces.UserManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Services.UserManagement
{
    public class AccountSerivces : IAccountServices
    {

        private readonly IConfiguration _configuration;
        private readonly UserManager<UserTbl> _userManager;
        private readonly SignInManager<UserTbl> _signInManager;
        public AccountSerivces(
            IConfiguration configuration,
            UserManager<UserTbl> userManager,
            SignInManager<UserTbl> signInManager)
        {
            _configuration = configuration;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<IdentityResult> Register(ApplicationUserDto input)
        {
            UserTbl newUser = new UserTbl();
            newUser.UserName = input.UserName;
            var result = await _userManager.CreateAsync(newUser, input.Password);
            return result;
        }

        public async Task<SignInResult> Login(ApplicationUserDto input)
        {

            var result = await _signInManager.PasswordSignInAsync(input.UserName, input.Password, false, false);

            // Deletes the cookies
            //Response.Cookies.Delete(".AspNetCore.Identity.Application");

            return result;
        }

        public async Task<string> Logout()
        {
            await _signInManager.SignOutAsync();
            return "User logged out.";

        }

        private UserTbl CreateUser()
        {
            try
            {
                return Activator.CreateInstance<UserTbl>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(UserTbl)}'. " +
                    $"Ensure that '{nameof(UserTbl)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private JwtSecurityToken GetToken()
        {

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: new List<Claim>(),
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
            return token;


        }
    }
}
