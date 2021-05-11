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
  public class AdminController : Controller
  {
    // private readonly ILogger<HomeController> _logger;

    private AdminService adminService;
    private MyDbContext myDbContext;

    public AdminController(AdminService adminService, MyDbContext myDbContext)
    {
      //   _logger = logger;
      this.adminService = adminService;
      this.myDbContext = myDbContext;
    }

    [HttpGet("/Admin/Index")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpGet("/Admin/AddProduct")]
    public IActionResult AddProduct(string productName, string imageUrl, string detail, int quantity, double price, int categoryID)
    {
      ViewBag.listCategory = adminService.GetListCategory();
    //   try
    //   {
        adminService.AddProductNew(productName, imageUrl, detail, quantity, price,categoryID);
        return View();
    //   }
    //   catch (System.Exception ex)
    //   {
    //     Console.WriteLine("Error : " + ex.Message);
    //     return View();
    //     throw;
    //   }
    //   return View();
    }

    [HttpGet("/Admin/Product")]
    public IActionResult Product()
    {
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
