using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Exhibition : BaseEntity
    {
        public Exhibition()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }

        public string Name { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
