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
    public class OwnershipService:IOwnershipService
    {
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public OwnershipService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<OwnedPictureModel> GetAllOwnedPics()
		{
			IEnumerable<OwnedPicture> opEntities = _unitOfWork.OwnedPictureRepository.GetAll();
			return _mapper.Map<IEnumerable<OwnedPictureModel>>(opEntities);
		}

		public void BuyPicture(int picId, int ownerId)
		{
			List<OwnedPicture> entity = _unitOfWork.OwnedPictureRepository.GetAll().ToList()
													 .FindAll(e => e.IdPicture==picId && e.IdOwner==ownerId);
            if (entity != null)
            {
				throw new Exception("This picture is not available for purchase");
            }
            else
            {
				OwnedPictureModel newPic = new OwnedPictureModel()
				{
					IdPicture = picId,
					IdOwner = ownerId, 
					BuyDate = DateTime.Now
				};
				OwnedPicture newEntity = _mapper.Map<OwnedPicture>(newPic);
				_unitOfWork.OwnedPictureRepository.Add(newEntity);
				_unitOfWork.Save();
            }


		}

		public OwnerModel GetOwner(int ownedPicid)
		{
			int? owner = _unitOfWork.OwnedPictureRepository.GetAll().ToList().Find(p => p.Id == ownedPicid).IdOwner;
			return _mapper.Map<OwnerModel>(_unitOfWork.OwnerRepository.Get((int)owner));
		}
	}
}
