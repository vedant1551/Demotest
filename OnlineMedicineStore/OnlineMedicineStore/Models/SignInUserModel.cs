using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore.Models
{
    public class SignInUserModel
    {
        [Required(ErrorMessage ="Please Enter E-mail ID"), /*EmailAddress(ErrorMessage ="Please Enter Valid E-mail ID")*/]
        [Display(Name ="Username/Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter a Password"),DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool RememberMe { get; set; }
    }
}
