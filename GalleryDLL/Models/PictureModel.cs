using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class PictureModel : BaseModel
    {
        private string name;
        private DateTime createDate;
        private int? price;
        private string genre;
        private string addInfo;
        private ArtistModel artist;
        private TechniqueModel technique;
        private OwnedPictureModel ownedPicture;
        private List<ExhibitedPictureModel> exhibitedPictures;

        public string Name { get => name; set => name = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public int? Price { get => price; set => price = value; }
        public string Genre { get => genre; set => genre = value; }
        public string AddInfo { get => addInfo; set => addInfo = value; }
        //public int IdArtist { get; set; }
        //public int IdTechnique { get; set; }
        public ArtistModel Artist { get => artist; set => artist = value; }
        public TechniqueModel Technique { get => technique; set => technique = value; }
        public OwnedPictureModel OwnedPicture { get => ownedPicture; set => ownedPicture = value; }
        public List<ExhibitedPictureModel> ExhibitedPictures { get => exhibitedPictures; set => exhibitedPictures = value; }
    }
}
