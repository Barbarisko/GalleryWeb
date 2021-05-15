using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class TicketModel : BaseModel
    {
        private DateTime buyDate;
        private CurrentExhibitionModel currentExhibition;

        // public int IdCurrExh { get; set; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }
        public CurrentExhibitionModel CurrentExhibition { get => currentExhibition; set => currentExhibition = value; }
    }
}
