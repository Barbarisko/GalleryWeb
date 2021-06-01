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
        
       public void AddNewExhibition(string name, int? price, string description)
        {
            Exhibition itemEntity = _unitOfWork.ExhibitionRepository.GetAll().ToList().Find(
                        i => i.Name == name);

            if (itemEntity != null)
            {
                throw new ArgumentException("This exhibition already exists! Find and edit it");
            }
            else
            {
                ExhibitionModel newItem = new ExhibitionModel()
                {
                    Name = name,
                    Price = price,
                    Description = description
                };

                Exhibition newItemEntity = _mapper.Map<Exhibition>(newItem);
                _unitOfWork.ExhibitionRepository.Add(newItemEntity);
            }
            _unitOfWork.Save();
        }

        public void DeleteExhibition(int exhId)
        {
            Exhibition exh =  _unitOfWork.ExhibitionRepository.Get(exhId);
            if (exh == null)
            {
                throw new KeyNotFoundException();
            }
             _unitOfWork.ExhibitionRepository.Delete(exhId);
            _unitOfWork.Save();
        }

        public void UpdateEXHById(int Id, string name, int price, string desc)
        {
            List<Exhibition> sortedItemEntities = _unitOfWork.ExhibitionRepository.GetAll()
                .ToList().FindAll(i => i.Id == Id);
            if (sortedItemEntities.Any())
            {
                foreach (Exhibition i in sortedItemEntities)
                {
                    i.Name = name;
                    i.Price = price;
                    i.Description = desc;

                    _unitOfWork.ExhibitionRepository.Update(i);
                    _unitOfWork.Save();
                }
            }
        }

      
    }
}
