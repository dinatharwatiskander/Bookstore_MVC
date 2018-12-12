using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_Core_Project.Models
{
    public class Enrollment
    {

        public int CustomerID { get; set; }
        public Customer _Customer { get; set; }

        public int BookID { get; set; }
        public Books _Book { get; set; }
    }
}
