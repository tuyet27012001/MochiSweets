using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace MochiSweets.Models
{
    public class ProductsTaste
    {
      public int tasteID {get; set;}
      public int productID {get; set;}
       [ForeignKey("productID")]
      public virtual Product Product {get; set;}
       [ForeignKey("tasteID")]
      public virtual Taste Taste {get; set;}

      public List<Taste> ListTaste { get; set; }
      public ProductsTaste(){}
    }
}