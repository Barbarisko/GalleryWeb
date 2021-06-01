using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IExhibitionService
    {
        IEnumerable<ExhibitionModel> GetAllExhibitions();
        ExhibitionModel GetExhById(int Id); 
        void AddNewExhibition(string name, int? price, string description);
        void UpdateEXHById(int Id, string name, int price, string desc);
        void DeleteExhibition(int exhId);
    }
}
