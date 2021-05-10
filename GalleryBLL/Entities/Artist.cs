using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Artist: BaseEntity
    {
        public Artist()
        {
            Pictures = new HashSet<Picture>();
        }

        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bday { get; set; }
        public DateTime? Death { get; set; }
        public string ArtDirection { get; set; }
        public string Telephone { get; set; }
        public int? IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
