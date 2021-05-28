using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Models
{
    public class TicketInCartModel : BaseModel
    {
        private int? totalPrice;
        private int? quantity;
        private string? cartId;
        private DateTime buyDate;
        private CurrentExhibitionModel currentExhibition;
        private int? curExhId;

        //public int? TicketId { get => ticketId; set => ticketId = value; }
        //public Ticket Ticket { get; set; }
        public int? TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int? Quantity { get => quantity; set => quantity = value; }
        public string? CartId { get => cartId; set => cartId = value; }
        public CurrentExhibitionModel CurrentExhibition { get => currentExhibition; set => currentExhibition = value; }
        public int? CurExhId { get => curExhId; set => curExhId = value; }
        public DateTime BuyDate { get => buyDate; set => buyDate = value; }

    }
}
