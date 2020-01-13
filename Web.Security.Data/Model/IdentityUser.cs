using Microsoft.AspNetCore.Identity;

namespace Web.Security.Data.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }

}
