using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionProject.Models;
using Microsoft.EntityFrameworkCore;
using ElectionProject.ModelView;
namespace ElectionProject.Controllers
{
    public class VoteController: Controller
    {
        private readonly ElectionContext _context;

        public VoteController(ElectionContext context)
        { 
            _context = context;
        }

        public IActionResult VoteFinal()
        {
            return View();
        }

        public IActionResult Index()
        {
            var sql = $@"select * from election
                          where end_date>='1999-11-14';";
            var election = _context.Set<Election>().FromSql(sql).ToList();
            return View(election);
        }

        public async Task<IActionResult> Vote(int electionId)
        {
            var sql = $@"select candidate.id, citizen.last_name, candidate.election_id from candidate
                         join citizen on citizen.id=candidate.citizen_id
                         where candidate.election_id={electionId};";
            var candidates = _context.Query<VoteResult>().FromSql(sql).ToList();

            return View(candidates);
        }

        [HttpPost]
        public async Task<IActionResult> Vote(int electionId,int candidateId, string citizenEmail)
        {
            var sql = $@"select district_id, id from citizen
                           where email = '{citizenEmail}' ;";
            
            var candidate = _context.Query<DistrictId>().FromSql(sql).ToList();
            int distrctId=candidate.ElementAt(0).district_id;
            int citizenId = candidate.ElementAt(0).id;
            var sql2 = $@"select * from vote
                          where citizen_id={citizenId} and election_id={electionId};";
            var vote = _context.Set<Vote>().FromSql(sql2).ToList();
            if (vote.Capacity == 0)
            {

                var count = _context.Vote.Count();
                int id = (Int32)count; id++;

                var sqlResult = $@"insert into vote values ({id},{electionId},{distrctId},{citizenId},{candidateId});";
                var Result = _context.Query<Insert>().FromSql(sqlResult).ToList();

                return Redirect("Index");
            }
            else
            {
                return Redirect("VoteFinal");
            }
        }


    }

}
