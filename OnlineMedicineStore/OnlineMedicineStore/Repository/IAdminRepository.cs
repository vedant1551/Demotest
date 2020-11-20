using OnlineMedicineStore.Models;
using System.Collections.Generic;
using OnlineMedicineStore.Data;

namespace OnlineMedicineStore.Repository
{
    public interface IAdminRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        
        Medicine GetMedicine(int id);
    }
}