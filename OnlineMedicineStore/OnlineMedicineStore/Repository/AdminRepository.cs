using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicineStore.Models;
using OnlineMedicineStore.Data;

namespace OnlineMedicineStore.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _context;

        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _context.ApplicationUsers;
        }

        public Medicine GetMedicine(int id)
        {
            return _context.Medicine.Find(id);
        }


    }
}
