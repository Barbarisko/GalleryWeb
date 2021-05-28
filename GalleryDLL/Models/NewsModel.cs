using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Models
{
    public class NewsModel : BaseModel
    {
        private string name;
        private string description;
        private string picUrl;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string PicUrl { get => picUrl; set => picUrl = value; }

    }
}
