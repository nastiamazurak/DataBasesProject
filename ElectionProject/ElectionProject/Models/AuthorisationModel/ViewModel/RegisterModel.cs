using System.ComponentModel.DataAnnotations;

namespace ElectionProject.Models.AuthorisationModel.ViewModel
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Please, enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is incorect")]
        public string ConfirmPassword { get; set; }


    }
}
