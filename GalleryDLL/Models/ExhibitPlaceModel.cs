using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ExhibitPlaceModel : BaseModel
    {
        private string name;
        private int? telephone;
        private CityModel city;
        private List<CurrentExhibitionModel> currentExhibitions;
        private int idCity;

        public string Name { get => name; set => name = value; }
        public int? Telephone { get => telephone; set => telephone = value; }
        public int IdCity { get => idCity; set => idCity = value; }

        public CityModel City { get => city; set => city = value; }
        public List<CurrentExhibitionModel> CurrentExhibitions { get => currentExhibitions; set => currentExhibitions = value; }
    }
}
