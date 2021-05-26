using System;
using System.Collections.Generic;

namespace MochiSweets.Models
{
  public class Customer
  {
    public int customerID { get; set; }
    public string customerName { get; set; }
    public string phonenumber { get; set; }
    public string gender { get; set; }
    public string birthDate { get; set; }
    public string email { get; set; }
    public string passwordCustomer { get; set; }
    public string image {get ; set;}
    public List<DeliveryAddress> ListAddress { get; set; }
    // public virtual ICollection<DeliveryAddress> DeliveryAddresss { get; set; }
    public Customer() { }
  }
}