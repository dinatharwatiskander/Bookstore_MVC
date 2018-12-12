using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_Core_Project.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }

        [Required]
        [StringLength(20,ErrorMessage ="Lenght Max 20")]
        [Display(Name ="BookName")]
        public string BookName { get; set; }

        [Required]
        [Column(TypeName ="decimal(5,2)")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }
        [Required]

        [Display(Name = "Quantity")]
        public int Quantity { get; set; } 
        public List<Publisher> publishers { get; set; }

        public ICollection<Enrollment> Customerlist { get; set; }

    }
    
    
}
