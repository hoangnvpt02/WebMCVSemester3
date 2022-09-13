using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WAD_T2104E_NguyenVanHoang.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base()
        {

        }
        public DbSet<CategoryModel> Category { get; set; }
        public DbSet<ProductModel> Product { get; set; }
    }

}