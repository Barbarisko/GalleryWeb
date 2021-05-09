using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class CityDTO:BaseDTO
    {
        private string name;
        private CountryDTO id_country;

        public string Name { get => name; set => name = value; }
        internal CountryDTO Id_country { get => id_country; set => id_country = value; }
    }
}
