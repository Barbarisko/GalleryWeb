using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class ExhibitedPicture : BaseEntity
    {
        [Required]
        public int IdCurrExh { get; set; }
        [Required]
        public int IdPicture { get; set; }
        [Required]
        public int Room { get; set; }

        public virtual CurrentExhibition CurrExh { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
