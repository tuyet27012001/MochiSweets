using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MochiSweets.Models
{
  public class Order
  {
    public int orderID { get; set; }
    public int paymentMethodID { get; set; }
    public int addressID { get; set; }
    public int orderStatus { get; set; }
    public DateTime dateTime { get; set; }
     [ForeignKey("addressID")]
    public virtual DeliveryAddress DeliveryAddress { get; set; }
    [ForeignKey("paymentMethodID")]
    public virtual PaymentsMethod PaymentsMethod { get; set; }
    // public virtual ICollection<OrdersProduct> OrdersProducts { get; set; }
    public List<OrdersProduct> ListOrdersProduct { get; set; }
    public Order() { }
  }
}