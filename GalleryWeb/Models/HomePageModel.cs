using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class HomePageModel
    {
        public List<ExhibitionModel> Exhibitions;
        //public List<CurrentExhibitionModel> CEItems;
        public List<NewsModel> NewsItems;

        public HomePageModel(List<ExhibitionModel> items/*, List<NewsModel> newsItems*/, List<CurrentExhibitionModel> cEItems)
        {
            Exhibitions = items;
            foreach(var i in items)
            {
                foreach(var c in cEItems)
                {
                    if(c.IdExh == i.Id)
                    {
                        i.CurrentExhibitions.Add(c);
                    }
                }
            }
            //NewsItems = newsItems;
        }
    }
}
