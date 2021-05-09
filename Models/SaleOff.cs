using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class SaleOff
    {
      public int saleID {get; set;}
      public double sale {get; set;}
      public DateTime startTime {get; set;}
      public DateTime endTime {get; set;}
      public int productID {get; set;}
       [ForeignKey("productID")]
     
      public virtual Product Product {get; set;}
      public SaleOff(){

      }
    }
}
