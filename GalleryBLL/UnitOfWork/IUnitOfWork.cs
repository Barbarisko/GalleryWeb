using GalleryDAL.Entities;
using GalleryDAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryDAL.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Artist> ArtistRepository { get; }
        IRepository<City> CityRepository { get; }
        IRepository<Country> CountryRepository { get; }
        IRepository<CurrentExhibition> CurrentExhibitionRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        IRepository<ExhibitedPicture> ExhibitedPictureRepository { get; }
        IRepository<Exhibition> ExhibitionRepository { get; }
        IRepository<ExhibitPlace> ExhibitPlaceRepository { get; }
        IRepository<OwnedPicture> OwnedPictureRepository { get; }
        IRepository<Owner> OwnerRepository { get; }
        IRepository<Picture> PictureRepository { get; }
        IRepository<Technique> TechniqueRepository { get; }
        IRepository<TicketsInCart> TicketsInCartRepository { get; }

        void Save();

    }
}
