using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class City
    {
        public City()
        {
            Artists = new HashSet<Artist>();
            Employees = new HashSet<Employee>();
            ExhibitPlaces = new HashSet<ExhibitPlace>();
        }

        public int IdCity { get; set; }
        public string Name { get; set; }
        public int IdCountry { get; set; }

        public virtual Country IdCountryNavigation { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ExhibitPlace> ExhibitPlaces { get; set; }
    }
}
