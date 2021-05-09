using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Exhibition
    {
        public Exhibition()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }

        public int IdExh { get; set; }
        public string Name { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
