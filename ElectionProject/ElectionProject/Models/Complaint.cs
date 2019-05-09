using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Complaint
    {
        public int Id { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        public int ObserverId { get; set; }
        public int TypeId { get; set; }
        public string Text { get; set; }

        public District District { get; set; }
        public Election Election { get; set; }
        public Observer Observer { get; set; }
        public Type Type { get; set; }
    }
}
