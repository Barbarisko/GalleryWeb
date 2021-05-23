using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class Artists
    {
		public List<ArtistModel> Items;

		public Artists(List<ArtistModel> items)
		{
			Items = items;
		}
	}
}
