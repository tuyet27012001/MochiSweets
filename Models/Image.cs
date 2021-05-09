using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
    public class Image
    {
      public int imageID {get; set;}
      public string imageUrl {get; set;}
      public int productID {get; set;}
      [ForeignKey("productID")]
      public virtual Product Product {get; set;}
      public Image(){}
    }
}