using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class CircuitHead
    {
        public int Id { get; set; }
        public int? ElectionId { get; set; }
        public int? CircuitId { get; set; }
        public int CitizenId { get; set; }

        public Circuit Circuit { get; set; }
        public Citizen Citizen { get; set; }
        public Election Election { get; set; }
    }
}
