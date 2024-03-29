﻿using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using GalleryWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GalleryWeb.Controllers
{
	public class CartController : Controller
	{
		ITicketService _ticketService;
        ICurrentExhibitionService _currExhService;
        IExhibitionService _exhService;

        private readonly UserManager<UserEntity> _userManager;
		public const string CartSessionKey = "сartId";

        public CartController(UserManager<UserEntity> userManager, ITicketService ticketService, 
            ICurrentExhibitionService currExhService, IExhibitionService exhService)
        {
            _userManager = userManager;
            _ticketService = ticketService;
            _currExhService = currExhService;
            _exhService = exhService;
        }

        public IActionResult BuyTicket(int curExId, int quantity)
        {
            CurrentExhibitionModel visitedExh = _currExhService.GetCurExhById(curExId);

            if (quantity <= visitedExh.MaxTicketQuantity)
            {
                _ticketService.AddTicketToCart(visitedExh, quantity, GetCartId().Result);
            }

            return RedirectToAction("Cart", "Cart", new { visitedExh.IdExh, curExId });
        }

        public IActionResult AddTicketToCartByPlus(int curExhId)
        {
            CurrentExhibitionModel ce = _currExhService.GetCurExhById(curExhId);

            if (ce.MaxTicketQuantity >= 1)
            {
                _ticketService.AddTicketToCart(ce, 1, GetCartId().Result);
            }

            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult RemoveItemFromCartByMinus(int ticketid, int curExhId)
        {
            _ticketService.RemoveTicketFromCart(ticketid, curExhId);
            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult RemoveItemFromCartByX(int ticketid, int curExhId)
        {
            _ticketService.DeleteItem(ticketid, curExhId);
            return RedirectToAction("Cart", "Cart");
        }

        public IActionResult Cart()
        {
            var ticketsFromCE = _ticketService.GetAllTicketsFromCart(GetCartId().Result);
            foreach(TicketInCartModel t in ticketsFromCE)
            {
                t.CurrentExhibition = _currExhService.GetCurExhById((int)t.CurExhId);
                t.CurrentExhibition.Exhibition = _exhService.GetExhById(t.CurrentExhibition.IdExh);
            }
            CartModel model = new CartModel(ticketsFromCE);
            return View(model);
        }
        
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
        public void SendTickets(string body, string email, string subject)
        {

            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("galleryweb.noreply@gmail.com");
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("galleryweb.noreply@gmail.com", "ZXCasdqwe123");
            smtp.EnableSsl = true;
            smtp.Send(mail);

        }
    }

}
