using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Picture : BaseEntity
    {
        public Picture()
        {
            ExhibitedPictures = new HashSet<ExhibitedPicture>();
        }
        [Required]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string Genre { get; set; }
        public string AddInfo { get; set; }
        [Required]
        public int IdArtist { get; set; }
        public int IdTechnique { get; set; }
        [Required]
        public string Url { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual Technique Technique { get; set; }
        public virtual ICollection<OwnedPicture> OwnedPicture { get; set; }
        public virtual ICollection<ExhibitedPicture> ExhibitedPictures { get; set; }
    }
}
