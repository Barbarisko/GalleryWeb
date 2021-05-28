using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class TicketModel : BaseModel
    {
        private DateTime buyDate;
        private CurrentExhibitionModel currentExhibition;
        private string _cartId;
        private int quantity;


        // public int IdCurrExh { get; set; }
       // public CurrentExhibitionModel CurrentExhibition { get => currentExhibition; set => currentExhibition = value; }
        public string CartId { get => _cartId; set => _cartId = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
