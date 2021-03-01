using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoshFoods.Models
{
    public class Branch
    {   [Key] 
        public int BranchID {get; set;}
        [Required]
        public string Address { get; set; }
        [Required] [MinLength (4), MaxLength(4)]
        public int Postcode { get; set; }
        [Required] [MinLength (3), MaxLength(3)] 
        public string State { get; set; }
        

    }
}
