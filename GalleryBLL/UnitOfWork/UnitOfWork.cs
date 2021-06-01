using GalleryDAL.Entities;
using GalleryDAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryDAL.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly GalleryDbContext _context;

        public IRepository<Artist> ArtistRepository { get; }
        public IRepository<City> CityRepository { get; }
        public IRepository<Country> CountryRepository { get; }
        public IRepository<CurrentExhibition> CurrentExhibitionRepository { get; }
        public IRepository<Employee> EmployeeRepository { get; }
        public IRepository<ExhibitedPicture> ExhibitedPictureRepository { get; }
        public IRepository<Exhibition> ExhibitionRepository { get; }
        public IRepository<ExhibitPlace> ExhibitPlaceRepository { get; }
        public IRepository<OwnedPicture> OwnedPictureRepository { get; }
        public IRepository<Owner> OwnerRepository { get; }
        public IRepository<Picture> PictureRepository { get; }
        public IRepository<Technique> TechniqueRepository { get; }
        public IRepository<TicketsInCart> TicketsInCartRepository { get; }

        public UnitOfWork(GalleryDbContext context, IRepository<Artist> artistrepository, IRepository<City> cityrepo, IRepository<Country> countryrepo,
                            IRepository<CurrentExhibition> currexhrepo, IRepository<Employee> employeerepo, IRepository<ExhibitedPicture> exhpicrepo,
                            IRepository<Exhibition> exibitionrepo, IRepository<ExhibitPlace> exhplacerepo, IRepository<OwnedPicture> ownpicrepo,
                            IRepository<Owner> ownerrepo, IRepository<Picture> picturerepo, IRepository<Technique> techniquerepo, IRepository<TicketsInCart> ticketsInCartRepository)
        {
            _context = context;
            ArtistRepository = artistrepository;
            CityRepository = cityrepo;
            CountryRepository = countryrepo;
            CurrentExhibitionRepository = currexhrepo;
            EmployeeRepository = employeerepo;
            ExhibitedPictureRepository = exhpicrepo;
            ExhibitionRepository = exibitionrepo;
            ExhibitPlaceRepository = exhplacerepo;
            OwnedPictureRepository = ownpicrepo;
            OwnerRepository = ownerrepo;
            PictureRepository = picturerepo;
            TechniqueRepository = techniquerepo;
            TicketsInCartRepository = ticketsInCartRepository;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
