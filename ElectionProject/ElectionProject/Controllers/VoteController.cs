using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ElectionProject.Data;
using Microsoft.AspNetCore.Mvc;
using ElectionProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectionProject.Controllers
{
    public class VoteController : Controller
    {
        private readonly ElectionContext _context;
        private readonly IElectionService _electionService;

        public VoteController(ElectionContext context, IElectionService electionService)
        {
            _context = context;
            _electionService = electionService;
        }

        public IActionResult Index()
        {
            return View(_electionService.GetPermitedElections());

        }


        public async Task<IActionResult> Vote(int electionId)
        {
            
           
            var vote = (await _context.Candidate.Where(x => x.ElectionId == electionId).ToListAsync()).OrderBy(x => x.Id);
            List<Candidate> candidate = new List<Candidate>();
            foreach (var VARIABLE in _context.Citizen)
            {
                if (vote.Where(x => VARIABLE.Id == x.CitizenId).FirstOrDefault()!=null)
                {
                    candidate.Add(vote.Where(x => VARIABLE.Id == x.CitizenId).FirstOrDefault());
                }
                
            }
             return View(candidate);
        }


    }

}
