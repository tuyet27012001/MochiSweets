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
      public string product_status {get; set;}
      public int categoryID {get; set;}
      [ForeignKey("categoryID")]
      public virtual Category Category {get; set;}
      // public virtual ICollection<SaleOff> SaleOffs {get; set;}
      // public virtual ICollection<Image> Images {get; set;}
   
      
     
     // public List<Product> listProduct = null;
      // public virtual ICollection<ProductsTaste> ProductsTastes {get; set;}
      
      public List<Image> ListImage { get; set; }

      public List<SaleOff> ListSaleOff { get; set; }
      public Product(){

      }

    }
}