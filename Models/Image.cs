using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectMVC.Models
{
    public partial class Image
    {
        public Image()
        {
            ImageReferences = new HashSet<ImageReference>();
        }

        public int ImageId { get; set; }
        public string ImagePath { get; set; }
        public string ImageCaption { get; set; }

        public virtual ICollection<ImageReference> ImageReferences { get; set; }
    }
}
