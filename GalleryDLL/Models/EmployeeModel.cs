using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class EmployeeModel : BaseModel
    {
        private string surname;
        private string name;
        private string lastName;
        private DateTime? bday;
        private string job;
        private string telephone;
        private string addInfo;
        private CityModel city;
        private List<CurrentExhibitionModel> currentExhibitions;
        private int idCity;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime? Bday { get => bday; set => bday = value; }
        public string Job { get => job; set => job = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int IdCity { get => idCity; set => idCity = value; }
        public string AddInfo { get => addInfo; set => addInfo = value; }

        public CityModel City { get => city; set => city = value; }
        public List<CurrentExhibitionModel> CurrentExhibitions { get => currentExhibitions; set => currentExhibitions = value; }
    }
}
