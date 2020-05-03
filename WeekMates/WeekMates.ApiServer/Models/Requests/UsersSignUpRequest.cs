using System.ComponentModel.DataAnnotations;

namespace WeekMates.ApiServer.Models.Requests
{
    public class UsersSignUpRequest
    {
        [Required(ErrorMessage = "Please input email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please input password.")]
        public string Password { get; set; }
    }
}