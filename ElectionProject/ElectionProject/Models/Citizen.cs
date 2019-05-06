using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appeal = new HashSet<Appeal>();
            Candidate = new HashSet<Candidate>();
            Election = new HashSet<Election>();
            HeadCircuit = new HashSet<HeadCircuit>();
            HeadDistrict = new HashSet<HeadDistrict>();
            Observer = new HashSet<Observer>();
        }

        public int CitizenId { get; set; }
        public string FirstName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birth { get; set; }
        public string Ipn { get; set; }

        public Vote Vote { get; set; }
        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Candidate> Candidate { get; set; }
        public ICollection<Election> Election { get; set; }
        public ICollection<HeadCircuit> HeadCircuit { get; set; }
        public ICollection<HeadDistrict> HeadDistrict { get; set; }
        public ICollection<Observer> Observer { get; set; }
    }
}
