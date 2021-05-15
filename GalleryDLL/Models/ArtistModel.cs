using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ArtistModel : BaseModel
    {
        private string surname;
        private string name;
        private string lastName;
        private DateTime bday;
        private DateTime? death;
        private string artDirection;
        private string telephone;
        private CityModel city;
        private List<PictureModel> pictures;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime Bday { get => bday; set => bday = value; }
        public DateTime? Death { get => death; set => death = value; }
        public string ArtDirection { get => artDirection; set => artDirection = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        //public int? IdCity { get; set; }

        public CityModel City { get => city; set => city = value; }
        public List<PictureModel> Pictures { get => pictures; set => pictures = value; }
    }
}
