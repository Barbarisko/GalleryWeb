using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Models
{
    public class TicketInCartModel : BaseModel
    {
        private int? ticketId;
        private int? totalPrice;
        private int? quantity;
        private string? cartId;

        public int? TicketId { get => ticketId; set => ticketId = value; }
        public Ticket Ticket { get; set; }
        public int? TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int? Quantity { get => quantity; set => quantity = value; }
        public string? CartId { get => cartId; set => cartId = value; }
    }
}
