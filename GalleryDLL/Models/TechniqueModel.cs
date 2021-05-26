using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class TechniqueModel : BaseModel
    {
        private string name;
        private string paint;
        private string _base;
        private List<PictureModel> pictures;
        private string picUrl;

        public string Name { get => name; set => name = value; }
        public string Paint { get => paint; set => paint = value; }
        public string Base { get => _base; set => _base = value; }
        public string PicUrl { get => picUrl; set => picUrl = value; }

        public List<PictureModel> Pictures { get => pictures; set => pictures = value; }
    }
}
