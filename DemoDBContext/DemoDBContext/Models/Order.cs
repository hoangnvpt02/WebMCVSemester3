using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoDBContext.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        // Foreign key
        public int CustId { get; set; }
        // Navigation properties
        public virtual Customer cust { get; set; }
    }

}