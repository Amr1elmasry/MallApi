﻿using System;
using System.Collections.Generic;

namespace MallAPI.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Customer User { get; set; } = null!;
    }
}
