using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Appeal
    {
        public int AppealId { get; set; }
        public int? ElectionId { get; set; }
        public int? CircuitId { get; set; }
        public int CitizenId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }

        public Circuit Circuit { get; set; }
        public Citizen Citizen { get; set; }
        public Election Election { get; set; }
        public Type Type { get; set; }
    }
}
