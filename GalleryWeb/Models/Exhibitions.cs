using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class Exhibitions
    {
        public List<ExhibitionModel> Items;

        public Exhibitions(List<ExhibitionModel> items)
        {
            Items = items;
        }
    }
}
