using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Controllers
{
	public class CartController : Controller
	{
		ITicketService _ticketService;
        ICurrentExhibitionService _currExhService;
		private readonly UserManager<UserEntity> _userManager;
		public const string CartSessionKey = "CartId";

        public CartController(UserManager<UserEntity> userManager, ITicketService ticketService, ICurrentExhibitionService currExhService)
        {
            _userManager = userManager;
            _ticketService = ticketService;
            _currExhService = currExhService;
        }

        public IActionResult BuyTicket(int curExId, int quantity)
        {
            CurrentExhibitionModel visitedExh = _currExhService.GetCurExhById(curExId);

            if (quantity <= visitedExh.MaxTicketQuantity)
            {
                _ticketService.AddTicketToCart(visitedExh, quantity, GetCartId().Result);
            }

            return RedirectToAction("Cart", "Home", new { visitedExh.IdExh, curExId });
        }

        //public IActionResult AddItemToCartByPlus(int stockId)
        //{
        //    Stock stock = _stockService.GetStockById(stockId);

        //    if (stock.Quantity >= 1)
        //    {
        //        _cartService.AddItemToCart(stock, 1, GetCartId().Result);
        //    }

        //    return RedirectToAction("Cart", "Cart");
        //}

        //public IActionResult RemoveItemFromCartByMinus(int itemId, int stockId)
        //{
        //	_cartService.RemoveItemFromCart(itemId, stockId);
        //	return RedirectToAction("Cart", "Cart");
        //}

        //public IActionResult RemoveItemFromCartByX(int itemId, int stockId)
        //{
        //	_cartService.DeleteItem(itemId, stockId);
        //	return RedirectToAction("Cart", "Cart");
        //}

        //public IActionResult Cart()
        //{
        //	CartModel model = new CartModel(_cartService.GetAllItemsFromCart(GetCartId().Result));
        //	return View(model);
        //}

        public async Task<string> GetCartId()
		{
			if (HttpContext.User.Identity.IsAuthenticated)
			{
				var user = await _userManager.GetUserAsync(User);

				return user.Email;
			}

			else if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(CartSessionKey)))
			{
				Guid tempCartId = Guid.NewGuid();
				HttpContext.Session.SetString(CartSessionKey, tempCartId.ToString());
			}

			return HttpContext.Session.GetString(CartSessionKey);
		}
	}

}
