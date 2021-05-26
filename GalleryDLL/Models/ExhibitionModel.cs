﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GalleryBLL.Models
{
    public partial class ExhibitionModel : BaseModel
    {
        private string name;
        private int? price;
        private List<CurrentExhibitionModel> currentExhibitions;
        private string description;

        public string Name { get => name; set => name = value; }
        public int? Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public List<CurrentExhibitionModel> CurrentExhibitions { get => currentExhibitions; set => currentExhibitions = value; }
    }
}
