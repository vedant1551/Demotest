using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineMedicineStore.Data;
using OnlineMedicineStore.Models;
using OnlineMedicineStore.Repository;


namespace OnlineMedicineStore.Controllers
{
    public class AdminController : Controller
    {
        // GET: AdminController
        private readonly AppDbContext Context;

        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly IAdminRepository _adminRepository;

        public AdminController(AppDbContext context,
            IWebHostEnvironment _webHostEnvironment,
            IAdminRepository adminRepository)
        {
            Context = context;

            _context = context;
            webHostEnvironment = _webHostEnvironment;
            _adminRepository = adminRepository;
        }


        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Medicineregister()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Medicineregister(Medicine med)
        {
            if (ModelState.IsValid)
            {
                //Write Your Code
                /* if(med.CoverPhoto != null)
                  {
                      string folder = "medicines/";
                      folder += Guid.NewGuid().ToString()+"_"+med.CoverPhoto.FileName;
                      string serverFolder = Path.Combine(webHostEnvironment.WebRootPath,folder);

                     await med.CoverPhoto.CopyToAsync(new FileStream(serverFolder,FileMode.Create));
                  }*/

                var medicine1 = new Medicine
                {

                    MedicineName = med.MedicineName,
                    Description = med.Description,
                    Category = med.Category,
                    Price = med.Price,
                    IsPrescriptionRequired = med.IsPrescriptionRequired

                };
                 Context.Medicine.Add(medicine1);

                 Context.SaveChanges();
                
                 ViewBag.IsMedicineRegistered = true;
                

                ModelState.Clear();
                return View();

            }
            return View(med);
        }

        //Admin Login
        /* public IActionResult AdminLogin()
         {
             return View();
         }

         [HttpPost]

         public IActionResult AdminLogin(string email1 , string password1)
         {

             if ( password1.Equals("admin") && email1.Equals("admin@gmail.com") )
             {
                 return View("/Admin/index/");
             }
             else
             {
                 //ViewBag.message = "invalid credentials !!";
                 return NotFound();
             }
         }*/

        //Admin Logout
        public IActionResult Logout()
        {
            return RedirectToAction("index", "Home");
        }

        //View Medicine
        public IActionResult ViewMedicine()
        {
            var items = Context.Medicine.ToList();
            return View(items);
        }

        public ActionResult Edit(int id)
        {

            return View(Context.Medicine.Where(x => x.Id == id).FirstOrDefault());

        }
        [HttpPost]
        public ActionResult Edit(int id, Medicine med1)
        {
            try
            {
                Context.Entry(med1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                Context.SaveChanges();
                return RedirectToAction("ViewMedicine");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Delete(int id)
        {

            return View(Context.Medicine.Where(x => x.Id == id).FirstOrDefault());



        }
        [HttpPost]
        public ActionResult Delete(int id, Medicine med1)
        {
            try
            {
                Medicine med2 = Context.Medicine.Where(x => x.Id == id).FirstOrDefault();
                Context.Medicine.Remove(med2);
                Context.SaveChanges();
                return RedirectToAction("ViewMedicine");
            }
            catch
            {
                return View();
            }

        }

        //View All Users

        [HttpGet]
        [Route("/view-users")]
        public ViewResult ViewUsers()
        {
            var allUsers = _adminRepository.GetAllUsers();
            return View(allUsers);
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(AdminModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Email.Equals("admin@gmail.com") && model.Password.Equals("admin"))
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Credintials");
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult MedicineDetails(int id)
        {
            var details = _adminRepository.GetMedicine(id);
            return View(details);
        }


    }
}
