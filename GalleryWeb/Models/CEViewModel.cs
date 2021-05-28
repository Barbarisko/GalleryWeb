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
        public List<CurrentExhibition> ceContext;

        public CEViewModel(List<CurrentExhibition> ceContext)
        {
            this.ceContext = ceContext;
        }


    }
}
