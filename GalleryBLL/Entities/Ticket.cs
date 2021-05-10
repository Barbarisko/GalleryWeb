using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Ticket : BaseEntity
    {
        public int IdCurrExh { get; set; }
        public DateTime BuyDate { get; set; }

        public virtual CurrentExhibition IdCurrExhNavigation { get; set; }
    }
}
