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
        public bool AddProductNew( string name, string detailProduct, int quantityProduct ,double priceProduct)
        {
            try
            {
                Product req = new Product();
                req.productName = name;
                req.price = priceProduct;
                req.detail = detailProduct;
                req.quantity = quantityProduct;
                req.product_status = "0";
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
       
       
       
    }
}