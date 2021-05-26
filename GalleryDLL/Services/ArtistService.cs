using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using GalleryDAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void AddArtist(ArtistModel artist)
        {
            _unitOfWork.ArtistRepository.Add(_mapper.Map<Artist>(artist));
            _unitOfWork.Save();
        }

        public void DeleteArtistById(int id)
        {
            _unitOfWork.ArtistRepository.Delete(id);
            _unitOfWork.Save();
        }
        public void UpdateArtist(int id, ArtistModel artist)
        {
            List<Artist> sortedtemEntities = _unitOfWork.ArtistRepository.GetAll()
                .ToList().FindAll(i => i.Id == id);
            if (sortedtemEntities.Any())
            {
                foreach (Artist i in sortedtemEntities)
                {
                    i.Name = artist.Name;
                    i.Surname = artist.Surname;
                    i.Telephone = artist.Telephone;
                    i.IdCity = artist.IdCity;
                    i.Bday = artist.Bday;
                    i.Death = artist.Death;
                    i.ArtDirection = artist.ArtDirection;
                    i.AddInfo = artist.AddInfo;

                    _unitOfWork.ArtistRepository.Update(i);
                    _unitOfWork.Save();
                }
            }
        }
    }
	
}
