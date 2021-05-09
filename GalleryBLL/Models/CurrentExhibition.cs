using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class CurrentExhibition
    {
        public CurrentExhibition()
        {
            ExhibitedPictures = new HashSet<ExhibitedPicture>();
            Tickets = new HashSet<Ticket>();
        }

        public int IdCurrExh { get; set; }
        public int IdEmployee { get; set; }
        public int IdExh { get; set; }
        public int IdExhPlace { get; set; }

        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual Exhibition IdExhNavigation { get; set; }
        public virtual ExhibitPlace IdExhPlaceNavigation { get; set; }
        public virtual ICollection<ExhibitedPicture> ExhibitedPictures { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
