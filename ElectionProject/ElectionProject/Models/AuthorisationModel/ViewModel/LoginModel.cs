using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ElectionProject.Models.AuthorisationModel.ViewModel
{
    public class LoginModel
    {  
        [Required(ErrorMessage = "Please, enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, enter correct password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
