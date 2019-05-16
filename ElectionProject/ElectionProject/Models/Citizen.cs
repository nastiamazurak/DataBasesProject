﻿using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class Citizen
    {
        public Citizen()
        {
            Appeal = new HashSet<Appeal>();
            Candidate = new HashSet<Candidate>();
            CircuitHead = new HashSet<CircuitHead>();
            DistrictHead = new HashSet<DistrictHead>();
            Election = new HashSet<Election>();
            Observer = new HashSet<Observer>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Ipn { get; set; }

        public Vote Vote { get; set; }
        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Candidate> Candidate { get; set; }
        public ICollection<CircuitHead> CircuitHead { get; set; }
        public ICollection<DistrictHead> DistrictHead { get; set; }
        public ICollection<Election> Election { get; set; }
        public ICollection<Observer> Observer { get; set; }
    }
}