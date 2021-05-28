using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class TicketsInCart : BaseEntity
    {
        public int? TotalPrice { get; set; }
        public int? Quantity { get ; set; }
        public string? CartId { get; set  ; }
        public CurrentExhibition CurrentExhibition { get; set ; }
        public int? CurExhId { get; set; }
        public DateTime BuyDate { get; set ; }
    }
}
