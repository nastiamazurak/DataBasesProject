using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectionProject.Controllers
{
    public class VoteController: Controller
    {
        private readonly ElectionContext _context;

        public VoteController(ElectionContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();
        }


        public async Task<IActionResult> Vote(int electionId)
        {

            return View();
            
           
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
