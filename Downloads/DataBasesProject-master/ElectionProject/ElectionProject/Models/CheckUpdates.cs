using System;
using System.Collections.Generic;

namespace ElectionProject.Models
{
    public partial class CheckUpdates
    {
        public int Id { get; set; }
        public int? CitizenId { get; set; }
        public int? UpdatesCount { get; set; }

        public Citizen Citizen { get; set; }
    }
}
