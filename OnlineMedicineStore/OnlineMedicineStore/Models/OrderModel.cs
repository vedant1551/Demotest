using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using OnlineMedicineStore.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineMedicineStore.Models
{
    public class OrderModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }
        
        public string ApplicationUserId { get; set; }
        public ApplicationUser AppUser { get; set; }
    }
}
