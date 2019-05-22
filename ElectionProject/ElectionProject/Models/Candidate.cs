using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            Observer = new HashSet<Observer>();
            Vote = new HashSet<Vote>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int? ElectionId { get; set; }
        public int CitizenId { get; set; }
        

        public Citizen Citizen { get; set; }
        public Election Election { get; set; }
        public ICollection<Observer> Observer { get; set; }
        public ICollection<Vote> Vote { get; set; }
    }
}
