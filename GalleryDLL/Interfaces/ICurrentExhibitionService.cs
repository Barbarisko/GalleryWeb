﻿using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface ICurrentExhibitionService
    {
        CurrentExhibitionModel GetCurExhById(int id);
        IEnumerable<CurrentExhibitionModel> GetAllCurrentExhibitions();

        void AddCurrentExhibition(int idExh, int idEmp, int idPlace, DateTime begin, DateTime end);
        void DeleteCurrentExhibition(int exhId);

        void AddPictureToExhibition(PictureModel picture, int exhId, int roomNum);
        List<ExhibitedPictureModel> GetAllPicsFromExhibition(int exhId);
         IEnumerable<ExhibitedPictureModel> GetAllExhPics();
        void CountEstimatePrice(int currexhId);
        void DeletePicFromExhibition(int picId, int currexhId);
    }
}
