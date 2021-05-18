using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Picture : BaseEntity
    {
        public Picture()
        {
            ExhibitedPictures = new HashSet<ExhibitedPicture>();
        }

        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public int? Price { get; set; }
        public string Genre { get; set; }
        public string AddInfo { get; set; }
        public int IdArtist { get; set; }
        public int IdTechnique { get; set; }

        public Artist IdArtistNavigation { get; set; }
        public Technique IdTechniqueNavigation { get; set; }
        public OwnedPicture OwnedPicture { get; set; }
        public ICollection<ExhibitedPicture> ExhibitedPictures { get; set; }
    }
}
