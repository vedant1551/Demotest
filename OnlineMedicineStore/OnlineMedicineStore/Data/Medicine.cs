using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using OnlineMedicineStore.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMedicineStore.Data
{
    public class Medicine
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Medicine Name")]
        [Display(Name = "Medicine")]

        public string MedicineName { get; set; }

        [Required(ErrorMessage = "Please Enter Medicine's Description ")]
        [Display(Name = "Description")]


        public string Description { get; set; }
        
        [Required(ErrorMessage = "Please Enter Category ")]
        [Display(Name = "Category")]

        public string Category { get; set; }

        [Required(ErrorMessage = "Please Enter Price")]
        [Display(Name = "Price")]

        public int Price { get; set; }

        [Required(ErrorMessage = "Please Enter whtether prescription will be required or not.")]
        [Display(Name = "Prescription")]

        public bool IsPrescriptionRequired { get; set; }

        //[Required]
        //[Display(Name ="Cover Photo")]

        //public IFormFile CoverPhoto { get; set; }

        //public string CoverImageUrl { get; set; }

    }
}
