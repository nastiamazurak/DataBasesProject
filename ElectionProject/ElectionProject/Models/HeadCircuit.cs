using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class HeadCircuit
    {
        public int HeadCircuitId { get; set; }
        public int? ElectionId { get; set; }
        public int? CircuitId { get; set; }
        public int CitizenId { get; set; }

        public Circuit Circuit { get; set; }
        public Citizen Citizen { get; set; }
        public Election Election { get; set; }
    }
}
