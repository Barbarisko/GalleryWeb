using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using GalleryDAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalleryBLL.Services
{
	public class TicketService : ITicketService
	{

		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public TicketService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}


        //public void AddItemToCart(Exhibition Exhibition, int quantity, string cartId)
        //{
        //    TicketsInCart ticketincartEntity = _unitOfWork.TicketsInCartRepository.GetAll().ToList().Find(
        //                i => i.CartId == cartId && i.Ticket.CurExh.IdExh == Exhibition.Id);

        //    if (ticketincartEntity != null)
        //    {
        //        ticketincartEntity.Quantity += quantity;
        //        ticketincartEntity.TotalPrice = ticketincartEntity.Ticket.CurExh.IdExhNavigation.Price * ticketincartEntity.Quantity;
        //        _unitOfWork.TicketsInCartRepository.Update(ticketincartEntity);
        //    }
        //    else
        //    {
        //        TicketInCartModel newItem = new TicketInCartModel()
        //        {
        //            ,
        //            Quantity = quantity,
        //            CartId = cartId,
        //            Price = stock.Price * quantity
        //        };

        //        CartOrderItemEntity newItemEntity = _mapper.Map<CartOrderItemEntity>(newItem);
        //        _unitOfWork.CartOrderItemRepository.Add(newItemEntity);
        //    }

        //    StockEntity stockEntity = _unitOfWork.StockRepository.Get(stock.Id);
        //    stockEntity.Quantity -= quantity;
        //    _unitOfWork.StockRepository.Update(stockEntity);

        //    _unitOfWork.Save();
        //}

        //public void RemoveItemFromCart(int itemId, int stockId)
        //{
        //    CartOrderItemEntity itemEntity = _unitOfWork.CartOrderItemRepository.Get(itemId);

        //    if (itemEntity.Quantity > 1)
        //    {
        //        itemEntity.Quantity--;
        //        itemEntity.Price = itemEntity.Stock.Price * itemEntity.Quantity;
        //        _unitOfWork.CartOrderItemRepository.Update(itemEntity);
        //    }
        //    else if (itemEntity.Quantity == 1)
        //    {
        //        _unitOfWork.CartOrderItemRepository.Delete(itemEntity.Id);
        //    }

        //    StockEntity stockEntity = _unitOfWork.StockRepository.Get(stockId);
        //    stockEntity.Quantity++;
        //    _unitOfWork.StockRepository.Update(stockEntity);

        //    _unitOfWork.Save();
        //}



        //public void DeleteItem(int itemId, int stockId)
        //{
        //    int quantity = _unitOfWork.CartOrderItemRepository.Get(itemId).Quantity;

        //    StockEntity stockEntity = _unitOfWork.StockRepository.Get(stockId);
        //    stockEntity.Quantity += quantity;
        //    _unitOfWork.StockRepository.Update(stockEntity);

        //    _unitOfWork.Save();
        //}


        //public List<CartOrderItem> GetAllItemsFromCart(string cartId)
        //{
        //    List<CartOrderItemEntity> sortedItemEntities = _unitOfWork.CartOrderItemRepository.GetAll()
        //        .ToList().FindAll(i => i.CartId == cartId);
        //    return _mapper.Map<List<CartOrderItem>>(sortedItemEntities);
        //}

        public void UpdateCartId(string oldId, string newId)
        {
            List<TicketsInCart> sortedItemEntities = _unitOfWork.TicketsInCartRepository.GetAll()
                .ToList().FindAll(i => i.CartId == oldId);
            if (sortedItemEntities.Any())
            {
                foreach (TicketsInCart i in sortedItemEntities)
                {
                    i.CartId = newId;
                    _unitOfWork.TicketsInCartRepository.Update(i);
                    _unitOfWork.Save();
                }
            }
        }

        //public void SetOrderId(string cartId, int orderId)
        //{
        //    List<CartOrderItemEntity> sortedItemEntities = _unitOfWork.CartOrderItemRepository.GetAll()
        //        .ToList().FindAll(i => i.CartId == cartId);
        //    if (sortedItemEntities.Any())
        //    {
        //        foreach (CartOrderItemEntity i in sortedItemEntities)
        //        {
        //            i.OrderId = orderId;
        //            _unitOfWork.CartOrderItemRepository.Update(i);
        //            _unitOfWork.Save();
        //        }
        //    }
        //}

        //public decimal CountTotalAmount(string cartId)
        //{
        //    decimal totalAmount = 0;

        //    List<CartOrderItemEntity> sortedItemEntities = _unitOfWork.CartOrderItemRepository.GetAll()
        //        .ToList().FindAll(i => i.CartId == cartId);

        //    if (sortedItemEntities.Any())
        //    {
        //        foreach (CartOrderItemEntity i in sortedItemEntities)
        //        {
        //            totalAmount += i.Price;
        //        }
        //    }

        //    return totalAmount;
        //}
    }
}
