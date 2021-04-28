using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class ExhibitionDTO:BaseDTO
    {
        private string name;
        private uint price;

        public string Name { get => name; set => name = value; }
        public uint Price { get => price; set => price = value; }
    }
}
