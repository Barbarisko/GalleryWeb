using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Exhibition : BaseEntity
    {
        public Exhibition()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }
        [Required]
        public string Name { get; set; }
        [Required]
        public int? Price { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Thumbnail { get; set; }

        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
