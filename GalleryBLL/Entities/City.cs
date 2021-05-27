using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class City:BaseEntity
    {
        public City()
        {
            Artists = new HashSet<Artist>();
            Employees = new HashSet<Employee>();
            ExhibitPlaces = new HashSet<ExhibitPlace>();
        }

        public string Name { get; set; }
        public int IdCountry { get; set; }

        public virtual Country Country { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ExhibitPlace> ExhibitPlaces { get; set; }
    }
}
