using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class OwnedPictureModel : BaseModel
    {
        private DateTime buyDate;
        private OwnerModel owner;
        private PictureModel picture;
        private int? idOwner;
        private int idPicture;

        public int? IdOwner { get => idOwner; set => idOwner = value; }
        public int IdPicture { get => idPicture; set => idPicture = value; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }
        public OwnerModel? Owner { get => owner; set => owner = value; }
        public PictureModel Picture { get => picture; set => picture = value; }
    }
}
