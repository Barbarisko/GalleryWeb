using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class TicketsInCart : BaseEntity
    {
        public int? TicketId { get; set; }
        public int? TotalPrice { get; set; }
        public int? Quantity { get; set; }
        public string? CartId { get; set ; }

        public virtual Ticket Ticket { get; set; }
    }
}
