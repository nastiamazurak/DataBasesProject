using ElectionProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OneDayFlat.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Не вказано ім'я!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не вказано прізвище!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не вказано по-батькові!")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Не вказано дату народження!")]
        public string BirthDate { get; set; }
        [Required(ErrorMessage = "Не вказано ідентифікаційний номер!")]
        public string Ipn { get; set; }
        [Required(ErrorMessage = "Не вказано номер дільниці!")]
        public int DistrictId { get; set; }
        [Required(ErrorMessage = "Не вказано Email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не вказано пароль!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введено невірно!")]
        public string ConfirmPassword { get; set; }
        public IEnumerable<District> Districts { get; set; }
    }
}
