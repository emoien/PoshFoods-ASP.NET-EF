using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PoshFoods.Models
{
    public class ContactUs
    {
        [Key]
        public int ID { get; set; }

        [RegularExpression(@"[a-zA-Z]{1,50}", ErrorMessage ="First Name must be letters only!!")]
        public string FirstName { get; set; }
        
        [RegularExpression(@"[a-zA-Z]{1,50}", ErrorMessage = "Last Name must be letters only!!")]
        public string LastName { get; set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$", ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }

        [RegularExpression(@"[0-9]{10}", ErrorMessage = "Number must be 10 digits!!")]
        [MaxLength(10)]
        public string Phone { get; set; }
       
        public string Message { get; set; }
    }
}
