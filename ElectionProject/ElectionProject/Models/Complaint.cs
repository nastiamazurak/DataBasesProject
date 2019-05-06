using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Complaint
    {
        public int ComplaintId { get; set; }
        public int? ElectionId { get; set; }
        public int? CircuitId { get; set; }
        public int ObserverId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }

        public Circuit Circuit { get; set; }
        public Election Election { get; set; }
        public Observer Observer { get; set; }
        public Type Type { get; set; }
    }
}
