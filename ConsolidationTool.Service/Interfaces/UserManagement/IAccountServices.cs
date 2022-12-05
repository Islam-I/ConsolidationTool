using ConsolidationTool.Core.Dtos;
using ConsolidationTool.Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolidationTool.Service.Interfaces.UserManagement
{
    public interface IAccountServices
    {
        Task<IdentityResult> Register(ApplicationUserDto input);
        Task<SignInResult> Login(ApplicationUserDto input);
        Task<string> Logout();
    }
}
