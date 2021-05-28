using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class NewsViewModel
    {
        public List<NewsModel> Items;

        public NewsViewModel(List<NewsModel> items)
        {
            Items = items;
        }
    }
}
