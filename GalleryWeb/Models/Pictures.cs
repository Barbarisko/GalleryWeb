using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class Pictures
    {
        public List<PictureModel> pics;

        public Pictures(List<PictureModel> pics)
        {
            this.pics = pics;
        }
        public Pictures(Pictures p)
        {
            this.pics = p.pics;
        }
        public Pictures()
        {
            this.pics = new List<PictureModel>();
        }
    }
}
