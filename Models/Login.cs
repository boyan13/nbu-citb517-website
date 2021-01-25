using System.ComponentModel.DataAnnotations;

namespace CITB517_WebApplication.Models
{
    public class Login
    {
        [Required(ErrorMessage = "This field is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required!")]
        public string Password { get; set; }
    }
}
