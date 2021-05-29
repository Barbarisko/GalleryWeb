﻿using GalleryBLL.Models;
using GalleryDAL.Entities;
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
        public string Message;
        public SingleExh(ExhibitionModel exhibition, CurrentExhibitionModel CurrentExhibition,
            List<ExhibitedPictureModel> pictures)
        {
            this.CurrentExhibition = CurrentExhibition;
            Exhibition = exhibition;
            
            if(CurrentExhibition.Tag == Status.future)
            {
                Message = $"looking forward to see you! \n Starting on {CurrentExhibition.DateBegin} " +
                    $"\n You can still book tickets!";
                Pictures = new List<ExhibitedPictureModel>();
            }
            else
            {
                Message = Exhibition.Description;
                Pictures = pictures;
            }
        }
    }
}
