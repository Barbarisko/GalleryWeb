using AutoMapper;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<ArtistModel, Artist>()
                .ForMember(d => d.Pictures, opt => opt.MapFrom(src => src.Pictures))
                .ReverseMap();
            CreateMap<CityModel, City>()
                .ForMember(d => d.Artists, opt => opt.MapFrom(src => src.Artists))
                .ForMember(d => d.Employees, opt => opt.MapFrom(src => src.Employees))
                .ForMember(d => d.ExhibitPlaces, opt => opt.MapFrom(src => src.ExhibitPlaces))
                .ReverseMap();
            CreateMap<CountryModel, Country>()
                .ForMember(d => d.Cities, opt => opt.MapFrom(src => src.Cities))
                .ReverseMap();
            CreateMap<CurrentExhibitionModel, CurrentExhibition>()
                .ForMember(d => d.ExhibitedPictures, opt => opt.MapFrom(src => src.ExhibitedPictures))
                .ForMember(d => d.Tickets, opt => opt.MapFrom(src => src.Tickets))
                .ReverseMap();
            CreateMap<EmployeeModel, Employee>()
                .ForMember(d => d.CurrentExhibitions, opt => opt.MapFrom(src => src.CurrentExhibitions))
                .ReverseMap();
            CreateMap<ExhibitedPictureModel, ExhibitedPicture>()
                .ReverseMap();
            CreateMap<ExhibitionModel, Exhibition>()
                .ForMember(d => d.CurrentExhibitions, opt => opt.MapFrom(src => src.CurrentExhibitions))
                .ReverseMap();
            CreateMap<ExhibitPlaceModel, ExhibitPlace>()
                .ForMember(d => d.CurrentExhibitions, opt => opt.MapFrom(src => src.CurrentExhibitions))
                .ReverseMap();
            CreateMap<OwnedPictureModel, OwnedPicture>()
                .ReverseMap();
            CreateMap<OwnerModel, Owner>()
                .ForMember(d => d.OwnedPictures, opt => opt.MapFrom(src => src.OwnedPictures))
                .ReverseMap();
            CreateMap<PictureModel, Picture>()
                .ForMember(d => d.OwnedPicture, opt => opt.MapFrom(src => src.OwnedPicture))
                .ReverseMap();
            CreateMap<TechniqueModel, Technique>()
                .ForMember(d => d.Pictures, opt => opt.MapFrom(src => src.Pictures))
                .ReverseMap();
            //CreateMap<TicketModel, Ticket>()
            //    .ReverseMap();
            CreateMap<NewsModel, News>()
                .ReverseMap();
            CreateMap<TicketInCartModel, TicketsInCart>()
                .ReverseMap();

        }
    }
}
