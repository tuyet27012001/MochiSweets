using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MochiSweets.Models;
using System.Security.Cryptography;
using System.Text;

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

    public Image getImageByImageID(int imageID)
    {
      Image img = dbContext.Image.FirstOrDefault(p => p.imageID == imageID);
      // product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return img;
    }

    public bool updateImage(string imageurl, int imageid)
    {
      var img = getImageByImageID(imageid);
      if (img != null)
      {
        img.imageUrl = imageurl;
        dbContext.Update(img);
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
      if(category != null){
      foreach (var item in listC)
        {
          if (item.categoryName.Equals(category))
          {
            id = item.categoryID;
          }
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
      if(category != null){
        foreach (var item in listC)
        {
          if (item.categoryName.Equals(category))
          {
            id = item.categoryID;
            Console.WriteLine(id);
          }
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

    public dynamic GetListCategorySearch(string search)
    {
      int total;
      List<Category> listCategory = new List<Category>();
      
      listCategory = dbContext.Category.OrderByDescending(s => s.categoryID).Where(s => (EF.Functions.Like(s.categoryName, $"%{search}%")
                     || EF.Functions.Like(s.categoryID, $"%{search}%"))&& (s.categoryName != null)).ToList();
      total = dbContext.Category.Where(
                     s => (EF.Functions.Like(s.categoryName, $"%{search}%")
                     || EF.Functions.Like(s.categoryID, $"%{search}%"))
                      && (s.categoryName != null)).Count();

      return new
      {
        listCategory = listCategory.ToList(),
        total = total,
      };
    }

    public List<Taste> GetListTaste()
    {
      List<Taste> listTaste = new List<Taste>();
      listTaste = dbContext.Taste.Where(s => s.tasteName != null).ToList();
      return listTaste;
    }
    
    public List<Category> GetListCategorySearch(string search, int limit, int page)
    {
      // List<Product> listProduct = new List<Product>();
      List<Category> listC = new List<Category>();
     
     
      int skip = page == 0 || page == 1 ? 0 : (limit * (page-1));
      
        listC = dbContext.Category.OrderByDescending(s => s.categoryID).Where(
            s => (EF.Functions.Like(s.categoryName, $"%{search}%")
                     || EF.Functions.Like(s.categoryID, $"%{search}%"))&& (s.categoryName != null)).Skip(skip).Take(limit).ToList();
      //OrderBy
      return listC;
    }

    public bool AddCategoryNew(string categoryName){
      try
      {
        Category req = new Category();
        req.categoryName = categoryName;
        dbContext.Add(req);
        dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error : " + ex.Message);
        return false;
      }
    }

    public bool deleteCategory(int categoryID)
    {
      Category img = dbContext.Category.FirstOrDefault(p => p.categoryID == categoryID);
      if (img != null)
      {
        img.categoryName = null;
        dbContext.Update(img);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public bool updateCategory(int categoryID, string categoryName)
    {
      Category img = dbContext.Category.FirstOrDefault(p => p.categoryID == categoryID);
      if (img != null)
      {
        img.categoryName = categoryName;
        dbContext.Update(img);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public Category getCategoryByCategoryID(int categoryID)
    {
      Category category = dbContext.Category.FirstOrDefault(p => p.categoryID == categoryID);
      // product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return category;
    }


    public bool AddFlavorNew(string tasteName, int quantity , int categoryID, string image){
      try
      {
        Taste req = new Taste();
        req.tasteName = tasteName;
        req.quantity = quantity;
        req.categoryID = categoryID;
        req.image = image;
        dbContext.Add(req);
        dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error : " + ex.Message);
        return false;
      }
    }

    public bool deleteTaste(int tasteID)
    {
      Taste img = dbContext.Taste.FirstOrDefault(p => p.tasteID == tasteID);
      if (img != null)
      {
        img.tasteName = null;
        dbContext.Update(img);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public Taste getTasteByTasteID(int tasteID)
    {
      Taste taste = dbContext.Taste.FirstOrDefault(p => p.tasteID == tasteID);
      // product.ListImage = dbContext.Image.Where(x => x.productID == productID).ToList();
      return taste;
    }

    public bool updateTaste(int tasteID, string tasteName, int quantity, string image)
    {
      Taste img = dbContext.Taste.FirstOrDefault(p => p.tasteID == tasteID);
      if (img != null)
      {
        img.tasteName = tasteName;
        img.quantity = quantity;
        if(image != null){
          img.image = image;
        }
        dbContext.Update(img);
        dbContext.SaveChanges();
        return true;
      }
      return false;
    }

    public List<Taste> GetListTasteSearch(string search, int limit, int page)
    {
      // List<Product> listProduct = new List<Product>();
      List<Taste> listC = new List<Taste>();
     
     
      int skip = page == 0 || page == 1 ? 0 : (limit * (page-1));
      
        listC = dbContext.Taste.OrderByDescending(s => s.tasteID).Where(
            s => (EF.Functions.Like(s.tasteName, $"%{search}%")
                     || EF.Functions.Like(s.tasteID, $"%{search}%"))&& (s.tasteName != null)).Skip(skip).Take(limit).ToList();
      //OrderBy
      return listC;
    }

    public dynamic GetListTasteSearch(string search)
    {
      int total;
      List<Taste> listTaste = new List<Taste>();
      
      listTaste = dbContext.Taste.OrderByDescending(s => s.categoryID).Where(s => (EF.Functions.Like(s.tasteName, $"%{search}%")
                     || EF.Functions.Like(s.tasteID, $"%{search}%"))&& (s.tasteName != null)).ToList();
      total = dbContext.Taste.Where(
                    s => (EF.Functions.Like(s.tasteName, $"%{search}%")
                     || EF.Functions.Like(s.tasteID, $"%{search}%"))&& (s.tasteName != null)).Count();

      return new
      {
        listTaste = listTaste.ToList(),
        total = total,
      };
    }

    public List<Account> GetListAccountSearch(string search, int limit, int page)
    {
      // List<Product> listProduct = new List<Product>();
      List<Account> listC = new List<Account>();
     
     
      int skip = page == 0 || page == 1 ? 0 : (limit * (page-1));
      
        listC = dbContext.Account.OrderByDescending(s => s.accountID).Where(
            s => (EF.Functions.Like(s.userName, $"%{search}%")
                     || EF.Functions.Like(s.accountID, $"%{search}%"))&& (s.accountStatus != null) && (s.accountID != 1)).Skip(skip).Take(limit).ToList();
      //OrderBy
      return listC;
    }

    public dynamic GetListAccountSearch(string search)
    {
      int total;
      List<Account> listTaste = new List<Account>();
      
      listTaste = dbContext.Account.OrderByDescending(s => s.accountID).Where(s => (EF.Functions.Like(s.userName, $"%{search}%")
                     || EF.Functions.Like(s.accountID, $"%{search}%"))&& (s.accountStatus != null) && (s.accountID != 1)).ToList();
      total = dbContext.Account.Where(
                    s => (EF.Functions.Like(s.userName, $"%{search}%")
                     || EF.Functions.Like(s.accountID, $"%{search}%"))&& (s.accountStatus != null) && (s.accountID != 1)).Count();

      return new
      {
        listTaste = listTaste.ToList(),
        total = total,
      };
    }

     public string GetMd5Hash(MD5 md5Hash, string input)
    {

      // Convert the input string to a byte array and compute the hash.
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes
      // and create a string.
      StringBuilder sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data 
      // and format each one as a hexadecimal string.
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }

      // Return the hexadecimal string.
      return sBuilder.ToString();
    }

    public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
    {
      string hashOfInput = GetMd5Hash(md5Hash, input);

      StringComparer comparer = StringComparer.OrdinalIgnoreCase;

      if (0 == comparer.Compare(hashOfInput, hash))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool AddAccountNew(string userName, string password, string accountStatus){
      try
      {
        MD5 mD5 = MD5.Create();
        Account req = new Account();
        req.userName = userName;
        req.passwordAccount = GetMd5Hash(mD5,password);
        req.accountStatus = accountStatus;
        dbContext.Add(req);
        dbContext.SaveChanges();
        return true;
      }
      catch (System.Exception ex)
      {
        Console.WriteLine("Error : " + ex.Message);
        return false;
      }
    }

    public Account Login(string userName , string accountPassword){
      MD5 md5Hash = MD5.Create();
      Account ac = new Account();
      ac = dbContext.Account.FirstOrDefault(a => a.userName == userName);
      if(ac != null){
        if(VerifyMd5Hash(md5Hash, accountPassword, ac.passwordAccount)){
          return ac;
        }
        else{
          return null;
        }
      }
      return null;
    }

    public bool ForgotPassword(string password, string passwordNew)
    {
      MD5 md5Hash = MD5.Create();
      Account ac = dbContext.Account.FirstOrDefault(p => p.accountID == 1);
      if (ac != null)
      {
        if(VerifyMd5Hash(md5Hash, password, ac.passwordAccount)){
          ac.passwordAccount = GetMd5Hash(md5Hash,passwordNew);
          dbContext.Update(ac);
          dbContext.SaveChanges();
          return true;
        }
      }
      return false;
    }

    // public bool loginAdmin(string userName, string password)
    // {
    //   Account ac = dbContext.Account.FirstOrDefault(p => p.tasteID == tasteID);
    //   if (ac != null)
    //   {
    //     return true;
    //   }
    //   return false;
    // }
  }
}