using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionProject.Models;

namespace ElectionProject.Controllers
{
    public class VoteController: Controller
    {
        public IActionResult Index()
        {

            return View();
        }


        public IActionResult Vote()
        {

            return View();
        }


    }

}
