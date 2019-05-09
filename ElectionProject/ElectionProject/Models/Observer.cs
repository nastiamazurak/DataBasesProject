using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Observer
    {
        public Observer()
        {
            Complaint = new HashSet<Complaint>();
        }

        public int Id { get; set; }
        public int? ElectionId { get; set; }
        public int? DistrictId { get; set; }
        public int CitizenId { get; set; }
        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }
        public Citizen Citizen { get; set; }
        public District District { get; set; }
        public Election Election { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
    }
}
