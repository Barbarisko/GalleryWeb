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
    public class CurrentExhibitionService:ICurrentExhibitionService
    {
        private readonly IUnitOfWork _unitOfWork;
        IMapper _mapper;

        public CurrentExhibitionService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void CountEstimatePrice(int currexhId)
        {
            List<ExhibitedPicture> list = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList().FindAll(p=>p.IdCurrExh==currexhId);
            var exhibition = _unitOfWork.CurrentExhibitionRepository.Get(currexhId);
            foreach (var pic in list)
            {
                exhibition.EstimatedPrice += _unitOfWork.PictureRepository.Get(pic.IdPicture).Price;
            }
            _unitOfWork.CurrentExhibitionRepository.Update(exhibition);
            _unitOfWork.Save();
        }

        public void DeletePicFromExhibition(int picId, int currexhId)
        {
            ExhibitedPicture itemEntity = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList()
                .Find(e => e.IdPicture == picId && e.IdCurrExh == currexhId);

            if (itemEntity == null)
            {
                throw new KeyNotFoundException("No such picture");
            }
            else
            {
                _unitOfWork.ExhibitedPictureRepository.Delete(itemEntity.Id);
            }

            _unitOfWork.Save();
        }

        public List<ExhibitedPictureModel> GetAllPicsFromExhibition(int cexhId)
        {
            List<ExhibitedPicture> exhPicEntities = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList()
                                                     .FindAll(e => e.IdCurrExh == cexhId);
            List<Picture> pictures = _unitOfWork.PictureRepository.GetAll().ToList();
            for(int i=0; i<exhPicEntities.Count; i++)
            {
                if(pictures[i].Id == exhPicEntities[i].IdPicture)
                {
                    exhPicEntities[i].Picture = pictures[i];
                }
            }
            return _mapper.Map<List<ExhibitedPictureModel>>(exhPicEntities);
        }
        public IEnumerable<CurrentExhibitionModel> GetAllCurrentExhibitions()
        {
            IEnumerable<CurrentExhibition> exhEntities = _unitOfWork.CurrentExhibitionRepository.GetAll();
            return _mapper.Map<IEnumerable<CurrentExhibitionModel>>(exhEntities);
        }
        public IEnumerable<ExhibitedPictureModel> GetAllExhPics()
        {
            IEnumerable<ExhibitedPicture> exhEntities = _unitOfWork.ExhibitedPictureRepository.GetAll();
            return _mapper.Map<IEnumerable<ExhibitedPictureModel>>(exhEntities);
        }

        public CurrentExhibitionModel GetCurExhById(int id)
        {
            return _mapper.Map<CurrentExhibitionModel>(_unitOfWork.CurrentExhibitionRepository.Get(id));
        }

        public void AddCurrentExhibition(int idExh, int idEmp, int idPlace, DateTime begin, DateTime end)
        {
            CurrentExhibition itemEntity = _unitOfWork.CurrentExhibitionRepository.GetAll().ToList().Find(
                        i => i.IdExh == idExh && i.IdExhPlace == idPlace);

            if (itemEntity != null)
            {
                throw new ArgumentException("This exhibition already exists! Find and edit it");
            }
            else
            {
                CurrentExhibitionModel newItem = new CurrentExhibitionModel()
                {
                    IdEmployee = idEmp,
                    IdExh = idExh,
                    IdExhPlace = idPlace,
                    Exhibition = _mapper.Map<ExhibitionModel>(_unitOfWork.ExhibitionRepository.Get(idExh)),
                    DateBegin = begin,
                    DateEnd = end
                };

                CurrentExhibition newItemEntity = _mapper.Map<CurrentExhibition>(newItem);
                _unitOfWork.CurrentExhibitionRepository.Add(newItemEntity);
            }
            _unitOfWork.Save();
        }


        public void DeleteCurrentExhibition(int exhId)
        {
            CurrentExhibition exh = _unitOfWork.CurrentExhibitionRepository.Get(exhId);
            if (exh == null)
            {
                throw new KeyNotFoundException();
            }
            _unitOfWork.CurrentExhibitionRepository.Delete(exhId);
            _unitOfWork.Save();
        }

        public void AddPictureToExhibition(PictureModel picture, int currexhId, int roomNum)
        {
            ExhibitedPicture picEntity = _unitOfWork.ExhibitedPictureRepository.GetAll().ToList().Find(
                p => p.IdCurrExh == currexhId && p.IdPicture == picture.Id);

            if (picEntity != null)
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
            _unitOfWork.Save();
        }
    }
}
