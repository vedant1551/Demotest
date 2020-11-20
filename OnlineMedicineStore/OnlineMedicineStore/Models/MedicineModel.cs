using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace OnlineMedicineStore.Models
{
    public class MedicineModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        
        public int Id { get; set; }
        
        [Required]
        [Display(Name ="Medicine Name")]
        public string MedicineName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "Price")]

        public int Price { get; set; }

        [Required]
        public bool IsPrescriptionRequired { get; set; }

        [Required]
        [Display(Name = "Choose Photo")]
        public IFormFile CoverPhoto { get; set; }


    }
}
