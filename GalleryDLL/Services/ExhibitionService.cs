using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Services
{
    public class ExhibitionService : IExhibitionService
    {
        public void AddNewExhibition(ExhibitionModel exhibition)
        {
            throw new NotImplementedException();
        }

        public void AddPictureToExhibition(ExhibitionModel exhibition, PictureModel picture)
        {
            throw new NotImplementedException();
        }

        public decimal CountEstimatePrice(string currexhId)
        {
            throw new NotImplementedException();
        }

        public void DeleteExhibition(int exhId)
        {
            throw new NotImplementedException();
        }

        public void DeletePicFromExhibition(int picId, int currexhId)
        {
            throw new NotImplementedException();
        }

        public List<ExhibitedPictureModel> GetAllPicsFromExhibition(string exhId)
        {
            throw new NotImplementedException();
        }

        public void UpdateExhibition(string oldId, string newId)
        {
            throw new NotImplementedException();
        }
    }
}
