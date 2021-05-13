using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MochiSweets.Models;
using MochiSweets.Services;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System.IO;
using Microsoft.AspNetCore.Hosting;


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

    [HttpPost("/Admin/AddProduct")]
    public IActionResult AddProduct(string productName, List<string> imageUrl, string detail, int quantity, double price, int categoryID)
    {
      
      ViewBag.listCategory = adminService.GetListCategory();
      
      List<Image> img = new List<Image>();
      if (productName != null)
      {
        foreach (var item in imageUrl)
        {
          Image i = new Image();
          i.imageUrl = "/Admin/img/" + item;
          img.Add(i);
         
        }

        Boolean x = adminService.AddProductNew(productName, img , detail, quantity, price, categoryID);
        if (x == true)
        {
          return Redirect("/Admin/Product");
        }
        
      }
      else{
          // Console.WriteLine("Tuyet Tuyet 2");
      }

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

    [HttpGet("/Admin/AddProduct")]
    public IActionResult AddProduct()
    {
       ViewBag.listCategory = adminService.GetListCategory();
      return View();
    }

    [HttpGet("/Admin/Product")]
    public IActionResult Product()
    {
      ViewBag.listProduct = adminService.GetListProduct();
      ViewBag.listImage = adminService.GetListImage();
      return View();
    }

    [HttpGet("/Admin/updateproduct")]
    public IActionResult updateproduct(int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");
      ViewBag.listCategory = adminService.GetListCategory();
      ViewBag.product = adminService.getProductByProductID(productID);
      ViewBag.listImage = adminService.GetListImage();
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
