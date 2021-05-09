using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Artist
    {
        public Artist()
        {
            Pictures = new HashSet<Picture>();
        }

        //private string surname;
        //private string name;
        //private string last_name;
        //private DateTime bday;
        //private DateTime death;
        //private string art_direction;
        //private string telephone;
        //private CityDTO id_city;

        public int IdArtist { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Bday { get; set; }
        public DateTime? Death { get; set; }
        public string ArtDirection { get; set; }
        public string Telephone { get; set; }
        public int? IdCity { get; set; }

        public virtual City IdCityNavigation { get; set; }
        public virtual ICollection<Picture> Pictures { get; set; }
    }
}
