using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Election
    {
        public Election()
        {
            Appeal = new HashSet<Appeal>();
            Candidate = new HashSet<Candidate>();
            CircuitHead = new HashSet<CircuitHead>();
            Complaint = new HashSet<Complaint>();
            DistrictHead = new HashSet<DistrictHead>();
            Observer = new HashSet<Observer>();
            Vote = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Tour { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int HeadOfCvk { get; set; }

        public Citizen HeadOfCvkNavigation { get; set; }
        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Candidate> Candidate { get; set; }
        public ICollection<CircuitHead> CircuitHead { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
        public ICollection<DistrictHead> DistrictHead { get; set; }
        public ICollection<Observer> Observer { get; set; }
        public ICollection<Vote> Vote { get; set; }
    }
}
