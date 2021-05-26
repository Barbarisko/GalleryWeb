using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryDAL.Entities
{
    public partial class Ticket : BaseEntity
    {
        public int IdCurrExh { get; set; }
        public DateTime BuyDate { get; set; }

        public CurrentExhibition CurrentExhibition { get; set; }
        public string CartId { get ; set; }
        public int Quantity { get; set; }
    }
}
