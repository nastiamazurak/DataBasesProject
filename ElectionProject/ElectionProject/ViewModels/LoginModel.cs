using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneDayFlat.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Не вказаний Email!")]
        [RegularExpression(@".+\@.+\..+", ErrorMessage = "Please enter a valid email address!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Не вказаний пароль!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
