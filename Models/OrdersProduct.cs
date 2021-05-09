using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class OrdersProduct
    {
      public int orderID {get; set;}
      public int productID {get; set;}  
      public int quantity {get; set;}
      public double price {get; set;}
      public double sale {get; set;}
       [ForeignKey("productID")]
      public virtual Product Product {get; set;}
      [ForeignKey("orderID")]
      public virtual Order Order {get; set;}
      public OrdersProduct(){}
    }
}