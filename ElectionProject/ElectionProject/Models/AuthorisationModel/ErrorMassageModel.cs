using System.ComponentModel.DataAnnotations;

namespace ElectionProject.Models.AuthorisationModel
{
    public class ErrorMassageModel
    {
        [Required(ErrorMessage = "Please, enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter corect password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

