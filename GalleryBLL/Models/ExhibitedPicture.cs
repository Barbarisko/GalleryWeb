using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ExhibitedPicture
    {
        public int IdExhPic { get; set; }
        public int IdCurrExh { get; set; }
        public int IdPicture { get; set; }
        public int Room { get; set; }

        public virtual CurrentExhibition IdCurrExhNavigation { get; set; }
        public virtual Picture IdPictureNavigation { get; set; }
    }
}
