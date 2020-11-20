using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineMedicineStore.Service;
using OnlineMedicineStore.Models;
using Microsoft.AspNetCore.Identity;
using System.Windows.Input;
using OnlineMedicineStore.Data;

namespace OnlineMedicineStore.Controllers
{

    public class HomeController : Controller
    {
        private static string username;

        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _context;



        public HomeController(IUserService userService,
            IEmailService emailService,
            UserManager<ApplicationUser> userManager,
            AppDbContext context)
        {
            _userService = userService;
            _emailService = emailService;
            _userManager = userManager;
            _context = context;
        }
        public ViewResult Index()
        {
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();

            return View();
        }

        [Authorize]
        public ViewResult AboutUs()
        {
            return View();
        }

        [Authorize]
        public ViewResult ContactUs()
        {
            return View();
        }



        [Authorize]
        [HttpGet]
        [Route("update-profile")]
        public IActionResult UpdateUser()
        {
            //var userId = _userManager.GetUserId(HttpContext.User);
            var userId = _userService.GetUserId();
            //var usernm = _userManager.GetUserName(HttpContext.User);
            if (userId == null)
            {
                return NotFound();
            }
            else
            {
                var user = _userManager.FindByIdAsync(userId).Result;
                username = user.UserName;
                return View(user);
            }

        }


        [Authorize]
        [HttpPost]
        [Route("update-profile")]
        public async Task<IActionResult> UpdateUser(ApplicationUser user)
        {
            user.UserName = username;
            if (ModelState.IsValid)
            {
                ApplicationUser apuser = _context.ApplicationUsers.Where(u => u.UserName == user.UserName).FirstOrDefault();

                apuser.FirstName = user.FirstName;
                apuser.LastName = user.LastName;
                apuser.ContactNo = user.ContactNo;
                apuser.Email = user.Email;

                if (apuser != null)
                {
                    _context.ApplicationUsers.Update(apuser);
                    await _context.SaveChangesAsync();
                    ViewBag.IsUpdated = true;
                    return View(apuser);

                }
            }
            return View(user);
        }
        public IActionResult viewuser_medicine()
        {

            Medicine med = new Medicine();
            ViewBag.medicines = _context.Medicine;
            return View();
        }

        public IActionResult myorder()
        {


            return View();        
        }
    
    }
}
