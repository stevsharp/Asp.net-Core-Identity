using Microsoft.AspNetCore.Identity;
using Web.Security.Data.Model;
using Web.Security.Domain.Interface;

namespace Web.Security.Domain.Service
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<IdentityUser> UserManager;
        //private readonly RoleManager<Role> RoleManager;
        //private readonly SignInManager<User> SignInManager;
    }
}
