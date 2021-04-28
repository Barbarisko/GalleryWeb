using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class ExhibitedPictureDTO:BaseDTO
    {
        private CurrentExhibitionDTO id_curr_exh;
        private PictureDTO id_picture;
        private uint room;//mb v enum

        public CurrentExhibitionDTO Id_curr_exh { get => id_curr_exh; set => id_curr_exh = value; }
        public PictureDTO Id_picture { get => id_picture; set => id_picture = value; }
        public uint Room { get => room; set => room = value; }
    }
}
