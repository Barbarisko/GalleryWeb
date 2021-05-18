using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class CityModel : BaseModel
    {
        private string name;
        private CountryModel country;
        private List<ArtistModel> artists;
        private List<EmployeeModel> employees;
        private List<ExhibitPlaceModel> exhibitPlaces;
        private int idCountry;

        public string Name { get => name; set => name = value; }
        public int IdCountry { get => idCountry; set => idCountry = value; }
        public CountryModel Country { get => country; set => country = value; }
        //public Country IdCountryNavigation { get; set; }
        public List<ArtistModel> Artists { get => artists; set => artists = value; }
        public List<EmployeeModel> Employees { get => employees; set => employees = value; }
        public List<ExhibitPlaceModel> ExhibitPlaces { get => exhibitPlaces; set => exhibitPlaces = value; }
    }
}
