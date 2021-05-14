using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class Product
    {
      public int productID {get ; set;}
      public string productName {get ; set ; }
      public double price {get; set ; }
      public string detail {get; set;}
      public int quantity {get; set;}
      public int product_status {get; set;}
      public int categoryID {get; set;}
      [ForeignKey("categoryID")]
      public virtual Category Category {get; set;}
      public List<Image> ListImage { get; set; }

      public List<SaleOff> ListSaleOff { get; set; }
      public Product(){

      }

    }
}