using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Circuit
    {
        public Circuit()
        {
            CircuitHead = new HashSet<CircuitHead>();
            District = new HashSet<District>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Center { get; set; }
        public string Address { get; set; }

        public ICollection<CircuitHead> CircuitHead { get; set; }
        public ICollection<District> District { get; set; }
    }
}
