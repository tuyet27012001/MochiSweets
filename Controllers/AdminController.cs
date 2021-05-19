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

    // [HttpGet("/Admin/Product")]
    // public IActionResult Product()
    // {

    //   ViewBag.listProduct = adminService.GetListProduct();
    //   ViewBag.listImage = adminService.GetListImage();
    //   return View();
    // }

    // [HttpGet("/Admin/Product")]
    // public IActionResult Product(string category, string search, int limit, int skip)
    // {
    //   // chưa có ssd à ???
    //   // e chua
    //   //.....
    //   // tự ái out đây
    //   //e xin loi
    //   // nghe chưa đây ?
    //   // bình thường khi m lấy dữ liệu từ client m phải truyền vào page với lại limit đấy là điều chắc chắn 
    //   // m phải từ cái limit với cái page để tính ra skip, chứ sao lại có một đống kia, mà cái công thức kia cũng sai bỏ mẹ, thay limit đi là tạch đúng chưa
    //   // giải thích logic đi  t xem nào, hay thêm số liều
    //   limit = 5;
    //   // if (adminService.GetListProductSearch(category ,search).Count % limit == 0)
    //   // {
    //   ViewBag.total = adminService.GetListProductSearch(category, search).total;
    //   // }
    //   // else{
    //   //   ViewBag.total = adminService.GetListProductSearch(category ,search).Count / limit + 1;
    //   // }
    //   // cái lấy total cũng sai, đã phân trang tức là nó lấy chỉ được số lượng bản ghi cho phép, m lấy tổng bản ghi thê snafo được bằng cách này, m phải dùng riêng 1 câu query mới lấy được chứ???
    //   //nhưng mà thế này e thấy cũng đù, m thử thế này thế nọ xem nào
    //   // làm chống cháy vớ va vớ vẩn,
    //   // m limit lấy 5 bản ghi từ database ra xong m lấy cái list đấy đêm count thì nó chỉ ra được 5 cái chứ nó lấy được hơn à
    //   ViewBag.listProduct = adminService.GetListProductSearch(category, search, limit, skip);
    //   ViewBag.search = search;
    //   ViewBag.select = category;
    //   ViewBag.listImage = adminService.GetListImage();
    //   ViewBag.listCategory = adminService.GetListCategory();

    //   ViewBag.skip = skip;
    //   ViewBag.skip1 = skip / limit;
    //   ViewBag.skip2 = skip / limit + 1;
    //   ViewBag.skip3 = skip / limit + 2;
    //   ViewBag.skip4 = skip - limit;
    //   ViewBag.skip5 = skip + limit;
    //   // thế t có skip 6 thì sao, skip 7 thì sao, cái này nó phải tự động tính ra chứ sao lại có cái biến bằng tay thế này
    //   //tại e nghĩ gì viết đấy thấy chạy dkd thì thôi
    //   // m thì giỏi rồi nhể, hay lắm
    //   // để e xem lại ạ
    //   // xem lại của m 
    //   //t mất niềm tin rồi
    //   //vâng 
    //   // vâng???????????????????????????e xem lại xem 
    //   ViewBag.limit = limit;

    //   return View();
    // }

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


    [HttpGet("/Admin/updateproduct")]
    public IActionResult updateproduct(int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");
      ViewBag.listCategory = adminService.GetListCategory();
      ViewBag.product = adminService.getProductByProductID(productID);
      ViewBag.listImage = adminService.GetListImage();
      return View();
    }

    [HttpGet("/Admin/deleteProduct")]
    public IActionResult deleteProduct(int productID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");

      ViewBag.product = adminService.deleteProduct(productID);
      return Redirect("/Admin/Product");
    }

    [HttpGet("/Admin/deleteImage")]
    public IActionResult deleteImage(int imageID)
    {
      // int?  productID = HttpContext.Session.GetInt32("productID");

      ViewBag.product = adminService.deleteImage(imageID);
      Product pro = adminService.getProductByImagrID(imageID);

      return Redirect("/Admin/updateproduct?productID=" + pro.productID);
    }



    [HttpPost("/Admin/updateproduct")]
    public IActionResult updateproduct(Product p, List<string> imageUrl)
    {
      ViewBag.product = adminService.getProductByProductID(p.productID);
      ViewBag.listImage = adminService.GetListImage();
      List<Image> img = new List<Image>();
      foreach (var item in imageUrl)
      {
        Image i = new Image();
        i.imageUrl = "/Admin/img/" + item;
        img.Add(i);
      }
      Boolean y = adminService.AddImage(img, p.productID);
      Boolean x = adminService.updateProduct(p, p.productID);
      if (x == true && y == true)
      {
        return Redirect("/Admin/Product");
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
