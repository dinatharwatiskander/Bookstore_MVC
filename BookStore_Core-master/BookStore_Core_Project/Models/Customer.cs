using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_Core_Project.Models
{
    public class Customer
    {

        [Key]
        public int CustomerID { get; set; }

        [Required (ErrorMessage = "Enter Your Name")]
        [Display (Name="Customer Name")]
        public string Name { get; set; }
        
        [Required (ErrorMessage = "Enter Your Address")]
        [Display (Name="Customer Address")]
        public string Address { get; set; }
        
        [Required (ErrorMessage = "Enter Your Phone")]
        [Display (Name="Customer Phone")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Created")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:yyyy-MM)", ApplyFormatInEditMode = true)]
        public DateTime Created { get;  set; }



        public ICollection<Enrollment> Booklist { get; set; }
        
        public List<Books> books { get; set; }

     

 
    }
}
