using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionProject.Models
{
    public class User
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string MyProperty { get; set; }
    }
}
