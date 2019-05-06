using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Election
    {
        public Election()
        {
            Appeal = new HashSet<Appeal>();
            Candidate = new HashSet<Candidate>();
            Complaint = new HashSet<Complaint>();
            HeadCircuit = new HashSet<HeadCircuit>();
            HeadDistrict = new HashSet<HeadDistrict>();
            Observer = new HashSet<Observer>();
            Vote = new HashSet<Vote>();
        }

        public int ElectionId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Tour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HeadOfCvk { get; set; }

        public Citizen HeadOfCvkNavigation { get; set; }
        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Candidate> Candidate { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
        public ICollection<HeadCircuit> HeadCircuit { get; set; }
        public ICollection<HeadDistrict> HeadDistrict { get; set; }
        public ICollection<Observer> Observer { get; set; }
        public ICollection<Vote> Vote { get; set; }
    }
}
