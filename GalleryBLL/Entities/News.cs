using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class News : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string PicUrl { get; set; }
    }
}
