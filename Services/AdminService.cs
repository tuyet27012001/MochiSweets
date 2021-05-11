using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MochiSweets.Models;


namespace MochiSweets.Services
{
  public class AdminService
  {
    private MyDbContext dbContext;
    public AdminService(MyDbContext dbContext)
    {
      this.dbContext = dbContext;
    }
    public bool AddProductNew(string productName,string imageUrl, string detail, int quantity, double price, int categoryID)
    {
      try
      {
        Product req = new Product();
        req.productName = productName;
        req.price = price;
        req.detail = detail;
        req.quantity = quantity;
        req.product_status = "0";
        req.categoryID = categoryID;
        dbContext.Add(req);
        dbContext.SaveChanges();
        Image img = new Image();
        img.imageUrl = imageUrl;
        var cate = dbContext.Product.FirstOrDefault();
        img.productID = cate.productID;
        dbContext.Add(img);
        dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error : " + ex.Message);
        return false;
      }
    }

    public List<Category> GetListCategory()
    {
      List<Category> listCategory = new List<Category>();
      listCategory = dbContext.Category.ToList();
      return listCategory;
    }
  }
}