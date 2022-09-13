using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace WAD_T2104E_NguyenVanHoang.Models
{
    public class ProductModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual CategoryModel Category { get; set; }


    }
}