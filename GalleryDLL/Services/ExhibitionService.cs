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
    public class ExhibitionService : IExhibitionService
    {
        private readonly IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public ExhibitionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void AddNewExhibition(int exhId)
        {
            throw new NotImplementedException();
        }

        public void AddPictureToExhibition(PictureModel picture, int currexhId, int roomNum)
        {
            ExhibitedPicture picEntity = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList().Find(
                p => p.IdCurrExh == currexhId && p.IdPicture == picture.Id);

            if(picEntity!= null)
            {
                throw new InvalidOperationException("this picture is already added");
            }
            else
            {
                ExhibitedPictureModel newPic = new ExhibitedPictureModel()
                {
                    IdPicture = picture.Id,
                    IdCurrExh = currexhId,
                    Room = roomNum
                };
                ExhibitedPicture newPicEntity = _mapper.Map<ExhibitedPicture>(newPic);
                _unitOfWork.ExhibitedPictureRepository.Add(newPicEntity);
            }

        }

        public decimal CountEstimatePrice(string currexhId)
        {
            throw new NotImplementedException();
        }

        public void DeleteExhibition(int exhId)
        {
            throw new NotImplementedException();
        }

        public void DeletePicFromExhibition(int picId, int currexhId)
        {
            throw new NotImplementedException();
        }

        public List<ExhibitedPictureModel> GetAllPicsFromExhibition(string exhId)
        {
            throw new NotImplementedException();
        }

        public void UpdateExhibition(string oldId, string newId)
        {
            throw new NotImplementedException();
        }
    }
}
