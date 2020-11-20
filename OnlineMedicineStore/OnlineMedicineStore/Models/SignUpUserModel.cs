using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace OnlineMedicineStore.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Please Enter your First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter your Username")]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        /*[Required(ErrorMessage = "Please Enter your Username")]
        [Display(Name = "Username")]
        public string Username { get; set; }*/

        [Required(ErrorMessage = "Please Enter your Contact No")]
        [Display(Name = "Contact No")]
        [Phone(ErrorMessage = "Please Enter Valid Contact No")]
        //[DataType(DataType.PhoneNumber)]
        public string ContactNo { get; set; }


        [Required(ErrorMessage ="Please Enter your E-mail ID")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage ="Please Enter a Valid E-Mail ID")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter a Strong Password")]
        [Display(Name = "Password")]
        [Compare("ConfirmPassword",ErrorMessage = "Password & Confirm Password are not Matching")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please Confirm a Password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
