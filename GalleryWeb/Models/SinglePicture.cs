using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class SinglePicture
    {
        public PictureModel Picture;

        public SinglePicture(PictureModel picture)
        {
            Picture = picture;
        }
    }
}
