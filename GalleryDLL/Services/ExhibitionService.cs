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


        public IEnumerable<ExhibitionModel> GetAllExhibitions()
        {
            IEnumerable<Exhibition> exhEntities = _unitOfWork.ExhibitionRepository.GetAll();
            return _mapper.Map<IEnumerable<ExhibitionModel>>(exhEntities);
        }
        public ExhibitionModel GetExhById(int id)
        {
            return _mapper.Map<ExhibitionModel>(_unitOfWork.ExhibitionRepository.Get(id));       
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

        public List<ExhibitedPictureModel> GetAllPicsFromExhibition(int cexhId)
        {
            List<ExhibitedPicture> exhPicEntities = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList();
                //.FindAll(e=>e.IdCurrExh == cexhId);

            return _mapper.Map<List<ExhibitedPictureModel>>(exhPicEntities);
        }

        public void UpdateExhibition(string oldId, string newId)
        {
            throw new NotImplementedException();
        }
    }
}
