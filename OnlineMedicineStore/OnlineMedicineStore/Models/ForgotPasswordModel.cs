using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OnlineMedicineStore.Models
{
    public class ForgotPasswordModel
    {
        [Required,EmailAddress,Display(Name ="Registered Email Address")]
        public string Email { get; set; }
        public bool EmailSent { get; set; }
    }
}
