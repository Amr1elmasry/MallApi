using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Review
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Subject { get; set; }
        public string? Description { get; set; }
        public int UserId { get; set; }

        public virtual Customer User { get; set; } = null!;
    }
}
