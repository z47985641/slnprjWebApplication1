﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMVC.Models
{
    public partial class AdminReference
    {
        public int AdminId { get; set; }
        public int RoomId { get; set; }
        public int AdminReferenceId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual Room Room { get; set; }
    }
}
