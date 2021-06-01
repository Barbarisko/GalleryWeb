using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Artist:BaseEntity
    {
        public Artist()
        {
            Pictures = new HashSet<Picture>();
        }

        [Required]
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bday { get; set; }
        public DateTime? Death { get; set; }
        [Required]
        public string ArtDirection { get; set; }
        public string Telephone { get; set; }
        public int? IdCity { get; set; }
        public string Surname { get; set; }
        public string Url { get; set; }
        public string AddInfo { get; set; }

        public  City City { get; set; }
        public  ICollection<Picture> Pictures { get; set; }
    }
}
