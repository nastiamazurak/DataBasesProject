using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class District
    {
        public District()
        {
            Appeal = new HashSet<Appeal>();
            Complaint = new HashSet<Complaint>();
            DistrictHead = new HashSet<DistrictHead>();
            Observer = new HashSet<Observer>();
            Vote = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CircuitId { get; set; }

        public Circuit Circuit { get; set; }
        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
        public ICollection<DistrictHead> DistrictHead { get; set; }
        public ICollection<Observer> Observer { get; set; }
        public ICollection<Vote> Vote { get; set; }
    }
}
