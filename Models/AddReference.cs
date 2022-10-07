using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMVC.Models
{
    public partial class AddReference
    {
        public int AddId { get; set; }
        public int OrderId { get; set; }
        public int AddReferenceId { get; set; }

        public virtual Add Add { get; set; }
        public virtual Order Order { get; set; }
    }
}
