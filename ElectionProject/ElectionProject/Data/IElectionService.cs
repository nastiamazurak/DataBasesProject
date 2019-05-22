using ElectionProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectionProject.Data
{
    public interface IElectionService
    {
        List<Election> GetPermitedElections();
    }
}
