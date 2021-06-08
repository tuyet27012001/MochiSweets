using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MochiSweets.Models;
using MochiSweets.Services;

namespace MochiSweets.Controllers
{
    public class UserController : Controller
    {
        private UserService userService;
        private MyDbContext myDbContext;

        public UserController(UserService userService, MyDbContext myDbContext)
        {
            this.userService = userService;
            this.myDbContext = myDbContext;
        }
        
        [HttpGet("/User/Login")]
        public IActionResult Login()
        {
          return View();
        }

        [HttpGet("/User/Register")]
        public IActionResult Register()
        {
          return View();
        }

        [HttpPost("/User/Register")]
        public IActionResult Register(string userName, string customerName, string phonenumber,
        string gender, string birthDate,string email, string passwordCustomer)
        {
          Boolean x = userService.AddCustomer(userName, customerName, phonenumber, gender, birthDate, email, passwordCustomer);
            if (x == true)
            {
            return Redirect("/User/Login");
            }
            else{
              Console.WriteLine("hong r");
            }
          return View();
        }

        [HttpPost("/User/Login")]
        public IActionResult Login(string userName, string passwordCustomer)
        {
          ViewBag.customer = userService.Login(userName, passwordCustomer);
          if(ViewBag.customer != null){
            return Redirect("/User/Home");
          }
          return View();
        }
       
       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
