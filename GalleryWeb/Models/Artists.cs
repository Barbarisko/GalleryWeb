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

		public Artists(List<ArtistModel> items, List<CityModel> cities, List<CountryModel> countries)
		{
			Items = items;
			foreach(ArtistModel a in Items)
            {
				foreach(CityModel c in cities)
                {
                    if (a.IdCity == c.Id)
                    {
                        a.City = c;
                    }
                }
                foreach(CountryModel co in countries)
                {
                    if(a.City.IdCountry == co.Id)
                    {
                        a.City.Country = co;
                    }
                }
            }            
		}
	}
}
