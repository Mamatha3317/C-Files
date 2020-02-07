using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVC.Models;
using HandsOnMVC.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
       
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            if (ModelState.IsValid)
            {
                

                return RedirectToAction("Login");
            }
            else
                return View(item);
            }
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details",user);
               // return RedirectToAction("Greet",new { id = 10 });
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details()
        {
            
            
                return View();
         

                
        }
        
       
    }
}

