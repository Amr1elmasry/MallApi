using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Product
    {
        public Product()
        {
            Carts = new HashSet<Cart>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? OldPrice { get; set; }
        public int? Price { get; set; }
        public string? Photo { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public string? Season { get; set; }
        public int? Catid { get; set; }
        public int? Quantity { get; set; }
        public int? SellerId { get; set; }
        public int? Discount { get; set; }
        public int? TimeToDis { get; set; }

        public virtual Category? Cat { get; set; }
        public virtual Seller? Seller { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
