﻿using AutoMapper;
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
		public List<PictureModel> GetAllPics()
		{
			List<Picture> picEntities = _unitOfWork.PictureRepository.GetAll().ToList();
			return _mapper.Map<List<PictureModel>>(picEntities);
		}

        public PictureModel GetPicById(int id)
        {
            Picture Entity = _unitOfWork.PictureRepository.Get(id);
           return  _mapper.Map<PictureModel>(Entity);            
        }

		public void AddPicture(string name, int price, DateTime createdate, string genre, string addInfo, string url,
									int idArtist, int idTechnique)
		{
			Picture itemEntity = _unitOfWork.PictureRepository.GetAll().ToList().Find(
						i => i.Name == name && i.CreateDate == createdate);

			if (itemEntity != null)
			{
				throw new ArgumentException("This pic already exists! Find and edit it");
			}
			else
			{
				PictureModel newItem = new PictureModel()
				{
					Name = name,
					Price = price,
					Genre = genre,
					CreateDate = createdate,
					AddInfo = addInfo,
					Url = url,
					IdArtist = idArtist,
					IdTechnique = idTechnique
			};

				Picture newItemEntity = _mapper.Map<Picture>(newItem);
				_unitOfWork.PictureRepository.Add(newItemEntity);
			}
			_unitOfWork.Save();
		}

		public void UpdatePicById(int Id, string name, int price, DateTime createdate, string genre, string addInfo, string url,
                                    int idArtist, int idTechnique)
		{
			List<Picture> sortedItemEntities = _unitOfWork.PictureRepository.GetAll()
				.ToList().FindAll(i => i.Id == Id);
			if (sortedItemEntities.Any())
			{
				foreach (Picture i in sortedItemEntities)
				{
					i.Name = name;
                    i.Price = price;
                    i.Genre = genre;
                    i.CreateDate = createdate;
                    i.AddInfo = addInfo;
                    i.Url = url;
                    i.IdArtist = idArtist;
                    i.IdTechnique = idTechnique;

					_unitOfWork.PictureRepository.Update(i);
					_unitOfWork.Save();
				}
			}
		}

		public void DeletePic(int itemId)
		{
			int artistId = _unitOfWork.PictureRepository.Get(itemId).IdArtist;

			_unitOfWork.PictureRepository.Delete(itemId);

			Artist artistEntity = _unitOfWork.ArtistRepository.Get(artistId);
			foreach(Picture p in artistEntity.Pictures)
            {
				if(p.Id == itemId)
                {
					artistEntity.Pictures.Remove(p);
				}
			}
			_unitOfWork.ArtistRepository.Update(artistEntity);

			_unitOfWork.Save();
		}
		public TechniqueModel GetTechById(int id)
		{
			Technique Entity = _unitOfWork.TechniqueRepository.Get(id);
			return _mapper.Map<TechniqueModel>(Entity);
		}

		public List<TechniqueModel> GetAllTechniqes()
		{
			List<Technique> tecEntities = _unitOfWork.TechniqueRepository.GetAll().ToList();
			return _mapper.Map<List<TechniqueModel>>(tecEntities);
		}
		public List<PictureModel> SortPicturesAZ(List<PictureModel> itemsToSort)
        {
			return itemsToSort.OrderBy(o => o.Name).ToList();
		}

        public List<PictureModel> SortPicturesZA(List<PictureModel> itemsToSort)
        {
			return itemsToSort.OrderByDescending(o => o.Name).ToList();
		}
		public List<PictureModel> FilterByGenre(List<PictureModel> itemsToSort, string genreName)
        {
			List<PictureModel> filtered = new List<PictureModel>();
			for(int i=0; i<itemsToSort.Count; i++)
			{
				if(itemsToSort[i].Genre==genreName)
                {
					filtered.Add(itemsToSort[i]);
                }
			}
			return filtered.OrderBy(o => o.Name).ToList();
        }

        public List<PictureModel> FilterByTechnique(List<PictureModel> itemsToSort, int techName)
        {
			List<PictureModel> filtered = new List<PictureModel>();

			for (int i = 0; i < itemsToSort.Count; i++)
			{
				if (itemsToSort[i].IdTechnique == techName)
				{
					filtered.Add(itemsToSort[i]);
				}
			}
			return filtered.OrderBy(o => o.Name).ToList();
		}

        public List<PictureModel> FilterByArtist(List<PictureModel> itemsToSort, int artistName)
        {
			List<PictureModel> filtered = new List<PictureModel>();

			for (int i = 0; i < itemsToSort.Count; i++)
			{
				if (itemsToSort[i].IdArtist == artistName)
				{
					filtered.Add(itemsToSort[i]);
				}
			}
			return filtered.OrderBy(o => o.Name).ToList();
		}
    }
}
