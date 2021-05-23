using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class ExhPicModel
    {
        public List<ExhibitedPictureModel> Items;

        public ExhPicModel(List<ExhibitedPictureModel> items)
        {
            Items = items;
        }
    }
}
