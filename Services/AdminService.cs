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
    public bool AddProductNew(string productName,List<Image> imageUrl, string detail, int quantity, double price, int categoryID)
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
        req.ListImage = imageUrl;
        dbContext.Add(req);
        dbContext.SaveChanges();
        List<Product> lp = new List<Product>();
        lp = GetListProduct();
        int a = 0;
        foreach (var item in lp)
        {
            a = item.productID;
        }
        var cate = dbContext.Product.FirstOrDefault();
        // foreach (var item in imageUrl)
        // {
        //   // Console.WriteLine(item.imageUrl);
        //   Image img = new Image();
        //   img.imageUrl = item.imageUrl;
        //   // Console.WriteLine(img.imageUrl);
        //   img.productID = a;
        //   dbContext.Add(img);
        //   dbContext.SaveChanges();
        // }
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

    public List<Product> GetListProduct()
    {
      List<Product> listProduct = new List<Product>();
      listProduct = dbContext.Product.OrderByDescending(s=>s.productID).ToList();
      //OrderBy
      return listProduct;
    }

    public List<Image> GetListImage()
    {
      List<Image> listImage = new List<Image>();
      listImage = dbContext.Image.ToList();
      return listImage;
    }

    public Product getProductByProductID(int productID)
    {
      Product product = dbContext.Product.FirstOrDefault(p => p.productID == productID);
      product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return product;
      // Seller seller = dbContext.Seller.FirstOrDefault(x => x.UserId == userId);
      // seller.SellerCategorys = dbContext.SellerCategory.Where(x => x.SellerId == seller.SellerId).ToList();
      // List<Category> listCategory = new List<Category>();
      // foreach (var item in seller.SellerCategorys)
      // {
      //   listCategory.Add(dbContext.Category.FirstOrDefault(x => x.CategoryId == item.CategoryId));
      // }
      // return listCategory;
    }
  }
}