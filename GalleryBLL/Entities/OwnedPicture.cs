using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class OwnedPicture:BaseEntity
    {
        public int? IdOwner { get; set; }
        public int IdPicture { get; set; }
        public DateTime BuyDate { get; set; }

        public virtual Owner Owner { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
