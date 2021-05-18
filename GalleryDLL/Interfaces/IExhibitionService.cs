using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IExhibitionService
    {
        void AddNewExhibition(int exhId);
        void AddPictureToExhibition(PictureModel picture, int exhId, int roomNum);
        void UpdateExhibition(string oldId, string newId);
        List<ExhibitedPictureModel> GetAllPicsFromExhibition(string exhId);
        decimal CountEstimatePrice(string currexhId);
        void DeleteExhibition(int exhId);
        void DeletePicFromExhibition(int picId, int currexhId);
        
        // void AddItemToCart(Stock stock, int quantity, string cartId);

        //when i will need a cart for tickets
        //void UpdateCartId(string oldId, string newId);
    }
}
