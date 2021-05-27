using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class ExhibitedPicture : BaseEntity
    {
        public int IdCurrExh { get; set; }
        public int IdPicture { get; set; }
        public int Room { get; set; }

        public virtual CurrentExhibition CurrExh { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
