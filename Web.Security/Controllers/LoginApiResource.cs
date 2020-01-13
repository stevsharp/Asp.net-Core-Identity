using System.ComponentModel.DataAnnotations;

namespace Web.Security.Controllers
{

    public class LoginApiResource
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}