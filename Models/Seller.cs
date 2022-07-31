using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Seller
    {
        public Seller()
        {
            Products = new HashSet<Product>();
        }

        public int? ProductId { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<Product> Products { get; set; }
    }
}
