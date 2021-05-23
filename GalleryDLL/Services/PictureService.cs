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
    public class PictureService:IPictureService
    {
        readonly IUnitOfWork _unitOfWork;
        IMapper _mapper;
        public PictureService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public List<PictureModel> GetAllPicsFromArtist(int artId)
		{
			List<Picture> picEntities = _unitOfWork.PictureRepository.GetAll()
				.ToList().FindAll(i => i.IdArtist == artId);
			return _mapper.Map<List<PictureModel>>(picEntities);
		}
	}
}
