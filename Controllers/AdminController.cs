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
    public IActionResult AddProduct(string productName,string photo, List<string> imageUrl, string detail, int quantity, double price, int categoryID)
    {
      ViewBag.listCategory = adminService.GetListCategory();
      List<Image> img = new List<Image>();
      Image im = new Image();
      im.imageUrl = "/Admin/img/" + photo;
      img.Add(im);
      if (productName != null)
      {
        foreach (var item in imageUrl)
        {
          Image i = new Image();
          i.imageUrl = "/Admin/img/" + item;
          img.Add(i);
        }
        Boolean x = adminService.AddProductNew(productName, img, detail, quantity, price, categoryID);
        if (x == true)
        {
          return Redirect("/Admin/Product");
        }
      }
      return View();
    }

    [HttpGet("/Admin/AddProduct")]
    public IActionResult AddProduct()
    {
      ViewBag.listCategory = adminService.GetListCategory();
      return View();
    }

    
    [HttpGet("/Admin/Product")]
    public IActionResult Product(string category, string search, int page)
    {
      if (page == 0)
      {
        page = 1;
      }
      int limit = 5;
      int num = adminService.GetListProductSearch(category, search).total;
      ViewBag.total = Math.Ceiling((double)num / limit);
      ViewBag.listProduct = adminService.GetListProductSearch(category, search, limit, page);
      ViewBag.search = search;
      ViewBag.select = category;
      ViewBag.listImage = adminService.GetListImage();
      ViewBag.listCategory = adminService.GetListCategory();

      ViewBag.previousPage = page - 1;
      ViewBag.page = page;
      ViewBag.nextPage = page + 1;
      return View();
    }

    [HttpGet("/Admin/ListCategory")]
    public IActionResult ListCategory(string search, int page)
    {
      if (page == 0)
      {
        page = 1;
      }
      int limit = 5;
      ViewBag.listTaste = adminService.GetListTaste();
      ViewBag.listProduct = adminService.GetListProduct();
      ViewBag.listCategory = adminService.GetListCategorySearch(search, limit, page);
      int num = adminService.GetListCategorySearch(search).total;
      ViewBag.total = Math.Ceiling((double)num / limit);
      ViewBag.search = search;
      ViewBag.previousPage = page - 1;
      ViewBag.page = page;
      ViewBag.nextPage = page + 1;
      @ViewBag.quantity = 0;
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

    [HttpGet("/Admin/updateImage")]
    public IActionResult updateImage(int imageID , int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");
      ViewBag.imageID = imageID;
      ViewBag.productID = productID;
      ViewBag.listImage = adminService.GetListImage();
      return View();
    }

    [HttpPost("/Admin/updateImage")]
    public IActionResult updateImage(List<string> imageUrl, string photo , int imageID , int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");
      ViewBag.imageID = imageID;
      ViewBag.productID = productID;
      ViewBag.listImage = adminService.GetListImage();
      List<Image> img = new List<Image>();
      if(imageUrl != null){
        foreach (var item in imageUrl)
        {
          if(item != null){
            Image i = new Image();
            i.imageUrl = "/Admin/img/" + item;
            img.Add(i);
          }
         
        }
        Boolean y = adminService.AddImage(img, productID);
      }
      
      if(photo != null){
        photo = "/Admin/img/" + photo;
        Boolean x = adminService.updateImage(photo, imageID);
      }
     
      
        return Redirect("/Admin/updateproduct?productID="+productID);
    
    }

    [HttpGet("/Admin/deleteProduct")]
    public IActionResult deleteProduct(int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");

      ViewBag.product = adminService.deleteProduct(productID);
      return Redirect("/Admin/Product");
    }

    [HttpGet("/Admin/deleteImage")]
    public IActionResult deleteImage(int imageID , int im)
    {
      ViewBag.product = adminService.deleteImage(imageID);
      Product pro = adminService.getProductByImagrID(imageID);
      return Redirect("/Admin/updateImage?productID=" + pro.productID+"&&imageID="+im);
    }



    [HttpPost("/Admin/updateproduct")]
    public IActionResult updateproduct(Product p)
    {
      ViewBag.product = adminService.getProductByProductID(p.productID);
      ViewBag.listImage = adminService.GetListImage();
      Boolean x = adminService.updateProduct(p, p.productID);
      if (x == true)
      {
        return Redirect("/Admin/Product");
      }
      return View();
    }

    [HttpGet("/Admin/AddCategory")]
    public IActionResult AddCategory()
    {
      return View();
    }

    [HttpPost("/Admin/AddCategory")]
    public IActionResult AddCategory(string categoryName)
    {
      if (categoryName != null)
      {
        
        Boolean x = adminService.AddCategoryNew(categoryName);
        if (x == true)
        {
          return Redirect("/Admin/ListCategory");
        }
      }
      return View();
    }

    [HttpGet("/Admin/deleteCategory")]
    public IActionResult deleteCategory(int categoryID)
    {
      bool x = adminService.deleteCategory(categoryID);
      return Redirect("/Admin/ListCategory");
    }

    [HttpGet("/Admin/updateCategory")]
    public IActionResult updateCategory(int categoryID)
    {
      int i = 0;
      int j = 0;
      List<Taste> listTaste = adminService.GetListTaste();
      List<Product> listProduct = adminService.GetListProduct();
      foreach (var item1 in listTaste)
                            {
                                if (item1.categoryID == categoryID)
                                {
                                    i++;
                                }
                            }
                        
                        foreach (var item2 in listProduct)
                            {
                                if (item2.categoryID == categoryID)
                                {
                                    j++;
                                }
                            }
        ViewBag.i = i;
                 ViewBag.j = j;           
      ViewBag.category = adminService.getCategoryByCategoryID(categoryID);
      return View();
    }

    [HttpPost("/Admin/updateCategory")]
    public IActionResult updateCategory(int categoryID, string categoryName)
    {
      ViewBag.category = adminService.getCategoryByCategoryID(categoryID);
      bool x = adminService.updateCategory(categoryID, categoryName);
      if(x == true){
        return Redirect("/Admin/ListCategory");
      }
      return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet("/Admin/ListFlavor")]
    public IActionResult ListFlavor(int categoryID, string search, int page)
    {
      if (page == 0)
      {
        page = 1;
      }
      int limit = 5;
      ViewBag.listTaste = adminService.GetListTasteSearch(search, limit, page);
      ViewBag.categoryID = categoryID;
      int num = adminService.GetListTasteSearch(search).total;
      ViewBag.total = Math.Ceiling((double)num / limit);
      ViewBag.search = search;
      ViewBag.previousPage = page - 1;
      ViewBag.page = page;
      ViewBag.nextPage = page + 1;
      @ViewBag.quantity = 0;
      return View();
    }

    [HttpGet("/Admin/AddFlavor")]
    public IActionResult AddFlavor(int categoryID)
    {
      ViewBag.categoryID = categoryID;
      return View();
    }

    [HttpPost("/Admin/AddFlavor")]
    public IActionResult AddFlavor(int categoryID, string tasteName, int quantity, string image)
    {
      ViewBag.categoryID = categoryID;
      if (tasteName != null)
      {
        Boolean x = adminService.AddFlavorNew(tasteName, quantity , categoryID, image);
        if (x == true)
        {
          return Redirect("/Admin/ListFlavor?categoryID="+categoryID);
        }
      }
      return View();
    }

    [HttpGet("/Admin/deleteTaste")]
    public IActionResult deleteTaste(int tasteID, int categoryID)
    {
      bool x = adminService.deleteTaste(tasteID);
      return Redirect("/Admin/ListFlavor?categoryID="+categoryID);
    }

    [HttpGet("/Admin/UpdateFlavor")]
    public IActionResult UpdateFlavor(int categoryID, int tasteID)
    {
      ViewBag.categoryID = categoryID;
      ViewBag.taste = adminService.getTasteByTasteID(tasteID);
      return View();
    }

    [HttpPost("/Admin/UpdateFlavor")]
    public IActionResult UpdateFlavor(int categoryID, int tasteID, string tasteName, int quantity, string image)
    {
      ViewBag.categoryID = categoryID;
      ViewBag.taste = adminService.getTasteByTasteID(tasteID);
      bool x = adminService.updateTaste(tasteID, tasteName, quantity, image);
      if(x == true){
        return Redirect("/Admin/ListFlavor?categoryID="+categoryID);
      }
      return View();
    }

    [HttpGet("/Admin/LoginAdmin")]
    public IActionResult LoginAdmin()
    {
      return View();
    }

    [HttpPost("/Admin/LoginAdmin")]
    public IActionResult LoginAdmin(string userName, string password)
    {
      ViewBag.account = adminService.Login(userName, password);
      if(ViewBag.account != null){
        return Redirect("/Admin/Index");
      }
      return View();
    }

    [HttpGet("/Admin/ListAccount")]
    public IActionResult ListAccount(string search, int page)
    {
      if (page == 0)
      {
        page = 1;
      }
      int limit = 5;
      ViewBag.listAccount = adminService.GetListAccountSearch(search, limit, page);
      // ViewBag.categoryID = categoryID;
      int num = adminService.GetListAccountSearch(search).total;
      ViewBag.total = Math.Ceiling((double)num / limit);
      ViewBag.search = search;
      ViewBag.previousPage = page - 1;
      ViewBag.page = page;
      ViewBag.nextPage = page + 1;
      @ViewBag.quantity = 0;
      return View();
    }

    [HttpGet("/Admin/AddAccount")]
    public IActionResult AddAccount()
    {
      return View();
    }

    [HttpPost("/Admin/AddAccount")]
    public IActionResult AddAccount(string userName, string password, string accountStatus)
    {
      Console.WriteLine(userName);
      Console.WriteLine(password);
      Console.WriteLine(accountStatus);
      if (userName != null)
      {
        Console.WriteLine("dsfds");
        Boolean x = adminService.AddAccountNew(userName, password , accountStatus);
        if (x == true)
        {
          return Redirect("/Admin/ListAccount");
        }
      }
      return View();
    }
    // [HttpPost("/Admin/LoginAdmin")]
    // public IActionResult LoginAdmin(string userName, string password)
    // {
    //   bool x = adminService.loginAdmin(userName, password);
    //   if(x == true){
    //     return Redirect("/Admin/Index");
    //   }
    //   return View();
    // }

  }
}
