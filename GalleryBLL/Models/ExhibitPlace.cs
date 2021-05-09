using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ExhibitPlace
    {
        public ExhibitPlace()
        {
            CurrentExhibitions = new HashSet<CurrentExhibition>();
        }

        public int IdExhPlace { get; set; }
        public string Name { get; set; }
        public int? Telephone { get; set; }
        public int IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<CurrentExhibition> CurrentExhibitions { get; set; }
    }
}
