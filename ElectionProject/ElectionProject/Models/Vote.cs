using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Vote
    {
        public int VoteId { get; set; }
        public int? ElectionId { get; set; }
        public int? CircuitId { get; set; }
        public int CitizenId { get; set; }
        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; }
        public Circuit Circuit { get; set; }
        public Citizen Citizen { get; set; }
        public Election Election { get; set; }
    }
}
