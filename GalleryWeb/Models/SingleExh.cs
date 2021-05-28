using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class SingleExh
    {
        public ExhibitionModel Exhibition;
        public CurrentExhibitionModel CurrentExhibition;
        public List<ExhibitedPictureModel> Pictures;
        public SingleExh(ExhibitionModel exhibition, CurrentExhibitionModel CurrentExhibition,
            List<ExhibitedPictureModel> pictures)
        {
            this.CurrentExhibition = CurrentExhibition;
            //Exhibition = exhibition;
            CurrentExhibition.Exhibition = exhibition;
            CurrentExhibition.ExhibitedPictures = pictures;
        }
    }
}
