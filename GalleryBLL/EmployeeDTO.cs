using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class EmployeeDTO:BaseDTO
    {
        private string surname;
        private string name;
        private string last_name;
        private DateTime bday;
        private string job;//to enum
        private string telephone;
        private CityDTO id_city;
        private string add_info;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Bday { get => bday; set => bday = value; }
        public string Job { get => job; set => job = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public CityDTO Id_city { get => id_city; set => id_city = value; }
        public string Add_info { get => add_info; set => add_info = value; }
    }
}
