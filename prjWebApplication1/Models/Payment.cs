﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class Payment
    {
        public Payment()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int PayId { get; set; }
        public string Payment1 { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
