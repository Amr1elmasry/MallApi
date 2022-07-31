using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Coupon
    {
        public Coupon()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? Coupon1 { get; set; }
        public int? Discount { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
