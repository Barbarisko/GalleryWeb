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


        public void AddTicketToCart(CurrentExhibitionModel Exhibition,int quantity, string cartId)
        {
            TicketsInCart ticketincartEntity = _unitOfWork.TicketsInCartRepository.GetAll().ToList().Find(
                        i => i.CartId == cartId && i.CurExhId== Exhibition.Id);
           
            var exh = _unitOfWork.ExhibitionRepository.Get(Exhibition.IdExh);

            if (ticketincartEntity != null)
            {
                ticketincartEntity.Quantity += quantity;
                ticketincartEntity.TotalPrice = exh.Price * ticketincartEntity.Quantity;
                _unitOfWork.TicketsInCartRepository.Update(ticketincartEntity);
            }
            else
            {
                if (Exhibition.MaxTicketQuantity > 0)
                {
                    TicketInCartModel newItem = new TicketInCartModel()
                    {
                        CurExhId = Exhibition.Id,
                        BuyDate = DateTime.Now,
                        Quantity = quantity,
                        CartId = cartId,
                        TotalPrice = exh.Price * quantity
                    };

                    TicketsInCart newItemEntity = _mapper.Map<TicketsInCart>(newItem);
                    _unitOfWork.TicketsInCartRepository.Add(newItemEntity);
                    _unitOfWork.Save();
                }
            }

            CurrentExhibition ticketsForExh = _unitOfWork.CurrentExhibitionRepository.Get(Exhibition.Id);
            ticketsForExh.maxTicketQuantity -= quantity;
            _unitOfWork.CurrentExhibitionRepository.Update(ticketsForExh);

            _unitOfWork.Save();
        }

        public void RemoveTicketFromCart(int itemId, int curExhId)
        {
            TicketsInCart itemEntity = _unitOfWork.TicketsInCartRepository.Get(itemId);
            CurrentExhibition exhibitionEntity = _unitOfWork.CurrentExhibitionRepository.Get(curExhId);

            if (itemEntity.Quantity > 1)
            {
                itemEntity.Quantity--;
                itemEntity.TotalPrice = _unitOfWork.ExhibitionRepository.Get(exhibitionEntity.IdExh).Price * itemEntity.Quantity;
                _unitOfWork.TicketsInCartRepository.Update(itemEntity);
            }
            else if (itemEntity.Quantity == 1)
            {
                _unitOfWork.TicketsInCartRepository.Delete(itemEntity.Id);
            }

            CurrentExhibition ceEntity = _unitOfWork.CurrentExhibitionRepository.Get(curExhId);
            ceEntity.maxTicketQuantity++;
            _unitOfWork.CurrentExhibitionRepository.Update(ceEntity);

            _unitOfWork.Save();
        }

             public void DeleteItem(int itemId, int curExId)
        {
            int quantity = (int)_unitOfWork.TicketsInCartRepository.Get(itemId).Quantity;

            CurrentExhibition ceEntity = _unitOfWork.CurrentExhibitionRepository.Get(curExId);
            ceEntity.maxTicketQuantity += quantity;
            _unitOfWork.CurrentExhibitionRepository.Update(ceEntity);

            _unitOfWork.TicketsInCartRepository.Delete(itemId);

            _unitOfWork.Save();
        }


        public List<TicketInCartModel> GetAllTicketsFromCart(string cartId)
        {
            List<TicketsInCart> sortedItemEntities = _unitOfWork.TicketsInCartRepository.GetAll()
                .ToList().FindAll(i => i.CartId == cartId);
            return _mapper.Map<List<TicketInCartModel>>(sortedItemEntities);
        }

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

        public decimal CountTotalAmount(string cartId)
        {
            decimal totalAmount = 0;

            List<TicketsInCart> sortedItemEntities = _unitOfWork.TicketsInCartRepository.GetAll()
                .ToList().FindAll(i => i.CartId == cartId);

            if (sortedItemEntities.Any())
            {
                foreach (TicketsInCart i in sortedItemEntities)
                {
                    totalAmount += Convert.ToDecimal(i.CurrentExhibition.Exh.Price);
                }
            }
            return totalAmount;
        }
    }
}
