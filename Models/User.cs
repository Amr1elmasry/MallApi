using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public decimal? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Password { get; set; }
        public string? Image { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Seller Seller { get; set; } = null!;
    }
}
