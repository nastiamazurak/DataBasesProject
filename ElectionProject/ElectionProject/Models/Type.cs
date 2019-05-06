using System;
using System.Collections.Generic;

namespace ElectionProject
{
    public partial class Type
    {
        public Type()
        {
            Appeal = new HashSet<Appeal>();
            Complaint = new HashSet<Complaint>();
        }

        public int TypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Appeal> Appeal { get; set; }
        public ICollection<Complaint> Complaint { get; set; }
    }
}
