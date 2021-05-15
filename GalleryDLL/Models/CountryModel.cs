using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class CountryModel : BaseModel
    {
        private string name;
        private List<CityModel> cities;

        public string Name { get => name; set => name = value; }

        public List<CityModel> Cities { get => cities; set => cities = value; }
    }
}
