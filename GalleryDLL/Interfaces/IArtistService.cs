using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IArtistService
    {
        IEnumerable<ArtistModel> GetAllArtists();
        ArtistModel GetArtistById(int id);

    }
}
