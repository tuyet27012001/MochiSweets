using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class Category
    {
      public int categoryID {get; set;}
      public string categoryName {get; set;}
     
      // public virtual ICollection<Product> Products  {get; set;}
      
      public List<Product> ListProduct { get; set; }
      public Category(){}
    }
}
