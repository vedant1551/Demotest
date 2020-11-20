using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineMedicineStore.Models
{
    public class InputModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Contact No")]
        [Phone(ErrorMessage = "Please Enter Valid Contact No")]

        public string ContactNo { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
