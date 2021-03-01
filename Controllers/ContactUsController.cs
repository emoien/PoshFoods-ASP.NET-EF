using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PoshFoods.Models;

namespace PoshFoods.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly AppDbContext _context;

        public ContactUsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        
        public async Task<IActionResult> Index([Bind("FirstName,LastName,Email,Phone,Message")] ContactUs contact)
        {
            if (string.IsNullOrEmpty(contact.FirstName))
            {
                ModelState.AddModelError("FirstName", "Please Enter your First Name!");
            }

            if (string.IsNullOrEmpty(contact.LastName))
            {
                ModelState.AddModelError("LastName", "Please Enter your Last Name!");
            }

            if (string.IsNullOrEmpty(contact.Phone))
            {
                ModelState.AddModelError("Phone", "Please Enter your Phone Number!");
            }

            if (string.IsNullOrEmpty(contact.Email))
            {
                ModelState.AddModelError("Email", "Please Enter your Email Address!");
            }

            if (string.IsNullOrEmpty(contact.Message))
            {
                ModelState.AddModelError("Message", "Please Enter your Message!");
            }





            if (ModelState.IsValid)
            {
                _context.Add(contact);
                await _context.SaveChangesAsync();
                return RedirectToAction("Success");
           }
            return View();
        }
        
        public IActionResult Success()
        {
            return View();
        }

        

    }
}
