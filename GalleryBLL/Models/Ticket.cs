using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class Ticket
    {
        public int IdTicket { get; set; }
        public int IdCurrExh { get; set; }
        public DateTime BuyDate { get; set; }

        public virtual CurrentExhibition IdCurrExhNavigation { get; set; }
    }
}
