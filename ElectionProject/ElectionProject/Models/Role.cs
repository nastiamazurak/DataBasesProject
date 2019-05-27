using ElectionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneDayFlat.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Citizen> Citizens { get; set; }
        public Role()
        {
            Citizens = new List<Citizen>();
        }
    }
}
