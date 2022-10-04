﻿using System;
using System.Collections.Generic;

#nullable disable

namespace prjWebApplication1.Models
{
    public partial class Comment
    {
        public int CommentId { get; set; }
        public int RoomId { get; set; }
        public int? CommentPoint { get; set; }
        public string CommentDetail { get; set; }

        public virtual Room Room { get; set; }
    }
}
