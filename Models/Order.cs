using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public int CusId { get; set; }
        public string? Status { get; set; }
        public int? Price { get; set; }
        public int? Delivery { get; set; }
        public int? TotalPrice { get; set; }
        public int? CouponId { get; set; }
        public string? CurrAddress { get; set; }
        public int? CurrPhone { get; set; }

        public virtual Coupon? Coupon { get; set; }
        public virtual Customer Cus { get; set; } = null!;
    }
}
