using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Ticket : BaseEntity
    {
        public Ticket()
        {
            //TicketsInCarts = new HashSet<TicketsInCart>();
        }

        public DateTime BuyDate { get; set; }
        public int? CurExhId { get; set; }

        public virtual CurrentExhibition CurExh { get; set; }
        //public virtual ICollection<TicketsInCart> TicketsInCarts { get; set; }
    }
}
