using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            //CreateMap<model, entity>()
            //    .ReverseMap();
            //CreateMap<Order, OrderEntity>()
            //    .ForMember(d => d.CartOrderItems, opt => opt.MapFrom(src => src.CartOrderItems))
            //    .ReverseMap();
        }
    }
}
