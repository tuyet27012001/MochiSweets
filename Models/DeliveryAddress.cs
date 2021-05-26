using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
  public class DeliveryAddress
  {
    public int addressID { get; set; }
    
    public string phonenumber { get; set; }
    public string city { get; set; }
    public string district { get; set; }
    public string address { get; set; }
    public string customerName { get; set; }
    public int addressStatus { get; set; }
    public string addressDefault { get; set; }
    public int customerID { get; set; }
    [ForeignKey("customerID")]
    public virtual Customer Customer {get; set;}
    // public virtual ICollection<Order> Orders { get; set; }
    public DeliveryAddress() { }
  }
}