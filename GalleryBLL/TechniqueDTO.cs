using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class TechniqueDTO:BaseDTO
    {
        private string name;
        private string paint;//to enum
        private string basement;//to enum

        public string Name { get => name; set => name = value; }
        public string Paint { get => paint; set => paint = value; }
        public string Basement { get => basement; set => basement = value; }
    }
}
