using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class ExhibitPlace : BaseEntity
    {
        public ExhibitPlace()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }

        public string Name { get; set; }
        public int? Telephone { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
