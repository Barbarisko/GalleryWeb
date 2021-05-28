using GalleryBLL.Models;
using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface ITicketService
    {
         void AddTicketToCart(CurrentExhibitionModel Exhibition, int quantity, string cartId);
         void RemoveTicketFromCart(int itemId, int curExhId);
         void UpdateCartId(string oldId, string newId);
         void DeleteItem(int itemId, int curExId);
         List<TicketInCartModel> GetAllTicketsFromCart(string cartId);
         decimal CountTotalAmount(string cartId);
    }
}
