using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class OwnedPictureDTO:BaseDTO
    {
        private OwnerDTO id_owner;
        private PictureDTO id_picture;
        private DateTime buy_date;

        public OwnerDTO Id_owner { get => id_owner; set => id_owner = value; }
        public PictureDTO Id_picture { get => id_picture; set => id_picture = value; }
        public DateTime Buy_date { get => buy_date; set => buy_date = value; }
    }
}
