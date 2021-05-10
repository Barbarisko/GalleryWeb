using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Technique : BaseEntity
    {
        public Technique()
        {
            Pictures = new HashSet<Picture>();
        }

        public string Name { get; set; }
        public string Paint { get; set; }
        public string Base { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
