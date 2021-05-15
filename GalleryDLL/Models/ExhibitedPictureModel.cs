using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ExhibitedPictureModel : BaseModel
    {
        private int room;
        private CurrentExhibitionModel currentExhibition;
        private PictureModel picture;

        //public int IdCurrExh { get; set; }
        //public int IdPicture { get; set; }
        public int Room { get => room; set => room = value; }
        public CurrentExhibitionModel CurrentExhibition { get => currentExhibition; set => currentExhibition = value; }
        public PictureModel Picture { get => picture; set => picture = value; }
    }
}
