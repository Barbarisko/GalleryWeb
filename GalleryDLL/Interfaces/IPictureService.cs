using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IPictureService
    {
        List<PictureModel> GetAllPicsFromArtist(int artId);
        List<PictureModel> GetAllPics();
        PictureModel GetPicById(int id);
        void AddPicture(string name, int price, DateTime createdate, string genre, string addInfo, string url,
                            int idArtist, int idTechnique);
        void UpdatePicById(int Id, string name, int price, DateTime createdate, string genre, string addInfo, string url,
                            int idArtist, int idTechnique);

        void DeletePic(int itemId);

        TechniqueModel GetTechById(int id);
        List<PictureModel> SortPicturesAZ(List<PictureModel> itemsToSort);
        List<PictureModel> SortPicturesZA(List<PictureModel> itemsToSort);
        List<PictureModel> FilterByGenre(List<PictureModel> itemsToSort, string genreName);


    }
}
