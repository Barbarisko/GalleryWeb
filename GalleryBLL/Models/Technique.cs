using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Technique
    {
        public Technique()
        {
            Pictures = new HashSet<Picture>();
        }

        public int IdTechnique { get; set; }
        public string Name { get; set; }
        public string Paint { get; set; }
        public string Base { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
