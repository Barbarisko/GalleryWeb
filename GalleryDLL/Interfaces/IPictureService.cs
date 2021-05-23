using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface IPictureService
    {
        List<PictureModel> GetAllPicsFromArtist(int artId);

    }
}
