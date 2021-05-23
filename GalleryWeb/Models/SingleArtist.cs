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
        public List<PictureModel> pics;

        public SingleArtist(ArtistModel artist, List<PictureModel> pics)
        {
            this.artist = artist;
            this.pics = pics;
        }
    }
}
