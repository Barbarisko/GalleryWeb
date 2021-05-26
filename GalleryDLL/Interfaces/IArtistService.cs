using GalleryBLL.Models;
using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<ArtistModel> GetAllArtists();
        ArtistModel GetArtistById(int id);
        void AddArtist(ArtistModel artist);
        void DeleteArtistById(int id);
        void UpdateArtist(int id, ArtistModel artist);
    }
}
