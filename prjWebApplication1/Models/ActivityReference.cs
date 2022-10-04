﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class ActivityReference
    {
        public int ActivityId { get; set; }
        public int OrderId { get; set; }
        public int ActivityReferenceId { get; set; }

        public virtual Activity Activity { get; set; }
        public virtual Order Order { get; set; }
    }
}
