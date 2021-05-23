using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class SingleExh
    {
        ExhibitionModel Exhibition;

        public SingleExh(ExhibitionModel exhibition)
        {
            Exhibition = exhibition;
        }
    }
}
