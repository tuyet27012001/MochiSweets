using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class Taste
    {
      public int tasteID {get; set;}
      public string tasteName {get; set;}
      public int quantity {get; set;}
      public int categoryID {get; set;}
      public string image {get; set;}
      [ForeignKey("categoryID")]
      public virtual Category Category {get; set;}
      // public virtual ICollection<ProductsTaste> ProductsTastes {get; set;}
      public Taste(){}
    }
}
