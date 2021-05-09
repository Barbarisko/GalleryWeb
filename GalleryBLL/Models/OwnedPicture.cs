using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class OwnedPicture
    {
        public int IdOwnedPicture { get; set; }
        public int? IdOwner { get; set; }
        public int IdPicture { get; set; }
        public DateTime BuyDate { get; set; }

        public virtual Owner IdOwnerNavigation { get; set; }
        public virtual Picture IdPictureNavigation { get; set; }
    }
}
