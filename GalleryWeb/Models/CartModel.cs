using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
	public class CartModel
	{

		public List<TicketInCartModel> Items;


		public CartModel(List<TicketInCartModel> items)
		{
			Items = items;
		}

	}
}
