using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class SingleArtist
    {
        public ArtistModel artist;

        public SingleArtist(ArtistModel artist, List<PictureModel> pics, CityModel city)
        {
            this.artist = artist;
            artist.Pictures = pics;
            artist.City = city;
        }
    }
}
