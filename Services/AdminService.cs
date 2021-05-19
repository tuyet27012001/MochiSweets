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
    public bool AddProductNew(string productName, List<Image> imageUrl, string detail, int quantity, double price, int categoryID)
    {
      try
      {
        Product req = new Product();
        req.productName = productName;
        req.price = price;
        req.detail = detail;
        req.quantity = quantity;
        req.product_status = 0;
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

    public bool AddImage(List<Image> image, int productID)
    {
      try
      {
        foreach (var item in image)
        {
          // Console.WriteLine(item.imageUrl);
          Image img = new Image();
          img.imageUrl = item.imageUrl;
          // Console.WriteLine(img.imageUrl);
          img.productID = productID;
          dbContext.Add(img);
          dbContext.SaveChanges();
        }
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
      listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(s => s.product_status == 0 || s.product_status == 1).ToList();
      return listProduct;
    }

    // public List<Product> GetListProduct(int limit, int skip)
    // {
    //   List<Product> listProduct = new List<Product>();
    //   listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(s=>s.product_status == 0 || s.product_status == 1).Skip(skip).Take(limit).ToList();
    //   return listProduct;
    // }

    public List<Image> GetListImage()
    {
      List<Image> listImage = new List<Image>();
      listImage = dbContext.Image.Where(s => s.imageUrl != null).ToList();
      return listImage;
    }

    public Product getProductByProductID(int productID)
    {
      Product product = dbContext.Product.FirstOrDefault(p => p.productID == productID);
      // product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return product;
    }

    public Product getProductByImagrID(int imageID)
    {
      Image img = dbContext.Image.FirstOrDefault(p => p.imageID == imageID);
      Product product = dbContext.Product.FirstOrDefault(p => p.productID == img.productID);
      // product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return product;
    }

    public bool updateProduct(Product product, int productID)
    {
      var product1 = getProductByProductID(productID);
      if (product1 != null)
      {
        product1.productName = product.productName;
        product1.detail = product.detail;
        product1.price = product.price;
        product1.quantity = product.quantity;
        product1.categoryID = product.categoryID;
        product1.product_status = product.product_status;
        dbContext.Update(product1);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public bool deleteProduct(int productID)
    {
      var product1 = getProductByProductID(productID);
      if (product1 != null)
      {
        product1.product_status = 2;
        dbContext.Update(product1);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public bool deleteImage(int imageID)
    {
      Image img = dbContext.Image.FirstOrDefault(p => p.imageID == imageID);
      if (img != null)
      {
        img.imageUrl = null;
        dbContext.Update(img);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public List<Product> GetListProductSearch(string category, string search, int limit, int page)
    {
      List<Product> listProduct = new List<Product>();
      List<Category> listC = new List<Category>();
      listC = GetListCategory();
      int id = 0;
      int skip = page == 0 || page == 1 ? 0 : (limit * (page-1));
      foreach (var item in listC)
      {
        if (item.categoryName.Equals(category))
        {
          id = item.categoryID;
        }
      }
      if (id != 0)
      {
        listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(
             s => (EF.Functions.Like(s.productName, $"%{search}%")
             || EF.Functions.Like(s.productID, $"%{search}%")) && (s.categoryID == id)
              && (s.product_status == 0 || s.product_status == 1)).Skip(skip).Take(limit).ToList();
      }
      else
      {
        listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(
                     s => (EF.Functions.Like(s.productName, $"%{search}%")
                     || EF.Functions.Like(s.productID, $"%{search}%"))
                      && (s.product_status == 0 || s.product_status == 1)).Skip(skip).Take(limit).ToList();
      }

      //OrderBy
      return listProduct;
    }

    public dynamic GetListProductSearch(string category, string search)
    {
      List<Product> listProduct = new List<Product>();
      List<Category> listC = new List<Category>();
      listC = GetListCategory();
      int id = 0;
      int total;
      // int total = dbContext.Product.Count();

      foreach (var item in listC)
      {
        if (item.categoryName.Equals(category))
        {
          id = item.categoryID;
          Console.WriteLine(id);
        }
      }
      if (id != 0)
      {
        listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(
               s => (EF.Functions.Like(s.productName, $"%{search}%")
               || EF.Functions.Like(s.productID, $"%{search}%")) && (s.categoryID == id)
                && (s.product_status == 0 || s.product_status == 1)).ToList();
        //OrderBy
         total = dbContext.Product.Where(s => (EF.Functions.Like(s.productName, $"%{search}%")
               || EF.Functions.Like(s.productID, $"%{search}%")) && (s.categoryID == id)
                && (s.product_status == 0 || s.product_status == 1)).Count();
      }
      else
      {
        listProduct = dbContext.Product.OrderByDescending(s => s.productID).Where(
                     s => (EF.Functions.Like(s.productName, $"%{search}%")
                     || EF.Functions.Like(s.productID, $"%{search}%"))
                      && (s.product_status == 0 || s.product_status == 1)).ToList();
        total = dbContext.Product.Where(s => (EF.Functions.Like(s.productName, $"%{search}%")
      || EF.Functions.Like(s.productID, $"%{search}%"))
      && (s.product_status == 0 || s.product_status == 1)).Count();
      }
      
      return new
      {
        listProduct = listProduct.ToList(),
        total = total,
      };
    }

  }
}