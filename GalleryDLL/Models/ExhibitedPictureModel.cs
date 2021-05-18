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
        private int idCurrExh;
        private int idPicture;

        public int IdCurrExh { get => idCurrExh; set => idCurrExh = value; }
        public int IdPicture { get => idPicture; set => idPicture = value; }
        public int Room { get => room; set => room = value; }
        public CurrentExhibitionModel CurrentExhibition { get => currentExhibition; set => currentExhibition = value; }
        public PictureModel Picture { get => picture; set => picture = value; }
    }
}
