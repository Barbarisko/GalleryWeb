using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class CountryDTO:BaseDTO
    {
        private string name;

        public string Name { get => name; set => name = value; }
    }
}
