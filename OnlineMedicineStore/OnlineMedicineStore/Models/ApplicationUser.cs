using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineMedicineStore.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Required(ErrorMessage = "Please Enter your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

       /* [Required(ErrorMessage = "Please Enter your Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }*/

        [Required(ErrorMessage = "Please Enter your Contact No")]
        [Display(Name = "Contact No")]
        [Phone(ErrorMessage = "Please Enter Valid Contact No")]
       
        
        public string ContactNo { get; set; }
    }
}
