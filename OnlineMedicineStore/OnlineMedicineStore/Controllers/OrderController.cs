using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineStore.Models;
using OnlineMedicineStore.Repository;
using OnlineMedicineStore.Service;
using Microsoft.AspNetCore.Identity;
using OnlineMedicineStore.Data;

namespace OnlineMedicineStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IUserService _userService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AppDbContext _context;
        private readonly AppDbContext _context1;

        public OrderController(IAccountRepository accountRepository,
            IUserService userService,
           UserManager<ApplicationUser> userManager,
           SignInManager<ApplicationUser> signInManager, AppDbContext context)
        {
            _context = context;
            _context1 = context;
            _accountRepository = accountRepository;
            _userService = userService;
            _userManager = userManager;
            _signInManager = signInManager;
        }




        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Myorder()
        {
            var userId = _userService.GetUserId();
            var orderes = _context.Orders;
            var oid = new List<int>();
            foreach (var tmp in orderes)
            {
                if (tmp.ApplicationUserId == userId)
                {
                    oid.Add(tmp.Id);
                }
            
            }
            ViewBag.oid = oid;
            var order1 =  _context1.OrderMedicines;
            var total = new List<int>();
            var medicinename = new List<List<string>>();
            var cost = new List<List<int>>();
            var c1 = new List<int>();
            var quantity = new List<List<int>>();
            var c2 = new List<int>();
           
            int i = 0;
            int j = 0;
            foreach (var tmp in oid)
            {
                int sum = 0;
                List<string> v1 = new List<string>();

                foreach (var tmp1 in order1)
                {

                    if (tmp == tmp1.OrderId)
                    {
                        sum += tmp1.Price_total;
                        c1.Add(tmp1.Price_total);
                        c2.Add(tmp1.Quantity);
                        var med = _context1.Medicine.Where(m => m.Id == tmp1.MedicineId).FirstOrDefault();
                        v1.Add(med.MedicineName);
                    }
                   
                }
                cost.Add(c1);
                quantity.Add(c2);
                medicinename.Add(v1);
               
                total.Add(sum);
                i++;
            }
            ViewBag.i = i;
            ViewBag.idea = 450;
            ViewBag.medname = medicinename;
            ViewBag.total = total;
            ViewBag.quantity = quantity;
            ViewBag.cost = cost;




            return View(order1);
        }



    }
}
