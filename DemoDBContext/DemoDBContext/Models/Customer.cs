using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoDBContext.Models
{
    public class Customer
    {
        public int CustId { get; set; }
        public string Name { get; set; }
        // Navigation property
        public virtual ICollection<Order> Orders { get; set; }
    }
}