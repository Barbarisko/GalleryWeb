using System;

namespace GalleryBLL
{
    public class ArtistDTO: BaseDTO
    {
        private string surname;
        private string name;
        private string last_name;
        private DateTime bday;
        private DateTime death;
        private string art_direction;
        private string telephone;
        private CityDTO id_city;

        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public DateTime Bday { get => bday; set => bday = value; }
        public DateTime Death { get => death; set => death = value; }
        public string Art_direction { get => art_direction; set => art_direction = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public CityDTO City { get => id_city; set => id_city = value; }
    }
}
