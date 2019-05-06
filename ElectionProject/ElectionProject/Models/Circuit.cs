using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Circuit
    {
        public Circuit()
        {
            Appeal = new HashSet<Appeal>();
            Complaint = new HashSet<Complaint>();
            District = new HashSet<District>();
            HeadCircuit = new HashSet<HeadCircuit>();
            Observer = new HashSet<Observer>();
            Vote = new HashSet<Vote>();
        }

        public int CircuitId { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DistrictName { get; set; }

        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
        public ICollection<District> District { get; set; }
        public ICollection<HeadCircuit> HeadCircuit { get; set; }
        public ICollection<Observer> Observer { get; set; }
        public ICollection<Vote> Vote { get; set; }
    }
}
