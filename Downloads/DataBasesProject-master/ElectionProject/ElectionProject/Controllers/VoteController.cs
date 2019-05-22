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


        public IActionResult Vote()

        {
            var sql = @"select candidate.id, citizen.first_name, citizen.last_name from citizen 
  join candidate on candidate.citizen_id = citizen.id;";

            var books = _context.Query<VoteProcess>().FromSql(sql).ToList();

            return View(books);
        }

        public IActionResult VoteFinal()
        {
            return View();
        }
    }

}
