using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Employee
    {
        public Employee()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }

        public int IdEmployee { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime? Bday { get; set; }
        public string Job { get; set; }
        public string Telephone { get; set; }
        public int IdCity { get; set; }
        public string AddInfo { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
