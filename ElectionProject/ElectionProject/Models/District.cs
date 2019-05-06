using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class District
    {
        public District()
        {
            HeadDistrict = new HashSet<HeadDistrict>();
        }

        public int DistrictId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Center { get; set; }
        public string Address { get; set; }
        public int CircuitId { get; set; }

        public Circuit Circuit { get; set; }
        public ICollection<HeadDistrict> HeadDistrict { get; set; }
    }
}
