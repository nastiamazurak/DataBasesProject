using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionProject.Models
{
    public class ElectionResult
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public double candidate_percent { get; set; }
    }
}
