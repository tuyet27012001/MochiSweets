using System;
using System.Collections.Generic;

namespace MochiSweets.Models
{
    public class PaymentsMethod
    {
      public int PaymentsMethodID {get; set;}
      public string PaymentsMethodName {get; set;}
      // public virtual ICollection<Order> Orders {get; set;}
      public PaymentsMethod(){}
    }
}
