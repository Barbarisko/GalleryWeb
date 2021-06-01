using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class Pictures
    {
        public List<PictureModel> pics;

        public Pictures(List<PictureModel> pics, List<ArtistModel> artists, List<TechniqueModel> techs)
        {
            this.pics = pics;
            foreach(PictureModel p in this.pics)
            {
                foreach(ArtistModel a in artists)
                {
                    if (p.IdArtist == a.Id)
                    {
                        p.Artist = a;
                    }
                }
                foreach(TechniqueModel t in techs)
                {
                    if (p.IdTechnique == t.Id)
                    {
                        p.Technique = t;
                    }
                }
            }
        }
        public Pictures(Pictures p)
        {
            this.pics = p.pics;
        }

    }
}
