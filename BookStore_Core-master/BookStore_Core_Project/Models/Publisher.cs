using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_Core_Project.Models
{
    public class Publisher
    {
        [Required]
        public int Name { get; set; }
        
        [Required]
        public string Phone { get; set; }
        
        [Required]
        public int publisherID { get; set; }
        
        
    }
}
