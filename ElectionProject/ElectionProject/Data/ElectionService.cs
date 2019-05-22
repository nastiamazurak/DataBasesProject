using ElectionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ElectionProject.Data
{
    public class ElectionService : IElectionService
    {
        private readonly ElectionContext _context;

        public ElectionService(ElectionContext context)
        {
            _context = context;
        }

        private List<Election> GetAllElections()
        { 
            return _context.Election.ToList();
        }

        private bool GetPermissionToElect(Election election)
        {
            if (election.StartDate < DateTime.Now && election.EndDate > DateTime.Now)
                return true;
            return false;
        }

        public  List<Election> GetPermitedElections()
        {
            List<Election> permitedElection = new List<Election>();
            foreach (var election in GetAllElections())
            {
                if (!GetPermissionToElect(election))
                    permitedElection.Add(election);
            }

            return permitedElection;
        }
    }
}
