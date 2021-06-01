using GalleryBLL.Models;
using GalleryDAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Models
{
    public class CEViewModel 
    {
        public List<decimal> Total;
        public List<CurrentExhibitionModel> ceContext;
        
        public CEViewModel(List<CurrentExhibitionModel> ceContext)
        {
            this.ceContext = ceContext;
           
        }
    }
}
