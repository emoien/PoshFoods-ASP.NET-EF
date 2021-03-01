using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoshFoods.Models
{
    public class Employee
    {   [Key]
        public int EmployeeID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required] 
        public DateTime JoinDate { get; set; }
        [Required] [MaxLength (10)]
        public int Phone { get; set; }
    }
}
