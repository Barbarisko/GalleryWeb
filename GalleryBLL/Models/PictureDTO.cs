using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class PictureDTO:BaseDTO
    {
        private string name;
        private DateTime create_date;
        private uint price;
        private string genre;
        private string add_info;
        private ArtistDTO id_artist;
        private TechniqueDTO id_technique;

        public string Name { get => name; set => name = value; }
        public DateTime Create_date { get => create_date; set => create_date = value; }
        public uint Price { get => price; set => price = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Add_info { get => add_info; set => add_info = value; }
        public ArtistDTO Id_artist { get => id_artist; set => id_artist = value; }
        public TechniqueDTO Id_technique { get => id_technique; set => id_technique = value; }
    }
}
