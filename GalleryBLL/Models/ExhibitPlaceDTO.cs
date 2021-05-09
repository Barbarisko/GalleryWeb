using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class ExhibitPlaceDTO:BaseDTO
    {
        private string name;
        private string telephone;
        private CityDTO id_city;

        public string Name { get => name; set => name = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public CityDTO Id_city { get => id_city; set => id_city = value; }
    }
}
