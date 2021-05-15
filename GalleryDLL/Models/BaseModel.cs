using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Models
{
    public class BaseModel
    {
        private int _id;

        public int Id { get => _id; set => _id = value; }
    }
}
