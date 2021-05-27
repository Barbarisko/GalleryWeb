using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class CurrentExhibition : BaseEntity
    {
        public CurrentExhibition()
        {
            ExhibitedPictures = new HashSet<ExhibitedPicture>();
            Tickets = new HashSet<Ticket>();
        }

        public int IdEmployee { get; set; }
        public int IdExh { get; set; }
        public int IdExhPlace { get; set; }
        public DateTime? DateBegin { get; set; }
        public DateTime? DateEnd { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Exhibition Exh { get; set; }
        public virtual ExhibitPlace ExhPlace { get; set; }
        public virtual ICollection<ExhibitedPicture> ExhibitedPictures { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
