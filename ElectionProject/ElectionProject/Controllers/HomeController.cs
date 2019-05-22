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
    public class HomeController : Controller
    {
        private readonly ElectionContext _context;

        public HomeController(ElectionContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {
            var sql = @"with sum_of_candidates as(select count(id) as sum1 from vote),
                       sum_of_votes as(select candidate_id,count(candidate_id)as sum2 from vote group by candidate_id)
                       select cit.first_name,cit.last_name,(cast(sov.sum2 as float)/(select sum1 from sum_of_candidates)*100)as candidate_percent 
                       from sum_of_votes as sov join candidate as ca on ca.id=sov.candidate_id
                       join citizen as cit on cit.id=ca.citizen_id 
                       join election as el on el.id=ca.election_id
                       group by cit.first_name,cit.last_name,candidate_percent;";
            var books = _context.Query<ElectionResult>().FromSql(sql).ToList();
            ViewData["Message"] = "Your application description page.";
            return View(books);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
