using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using GalleryDAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GalleryBLL.Services
{
    public class ArtistService : IArtistService
    {
        readonly IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public ArtistService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public IEnumerable<ArtistModel> GetAllArtists()
        {
            IEnumerable<Artist> artistEntities = _unitOfWork.ArtistRepository.GetAll();
            return _mapper.Map<IEnumerable<ArtistModel>>(artistEntities);
        }

        public ArtistModel GetArtistById(int id)
        {
            Artist entity = _unitOfWork.ArtistRepository.Get(id);

			if (entity != null)
			{
				return _mapper.Map<ArtistModel>(entity);
			}
			return null;
		}
    }
	
}
