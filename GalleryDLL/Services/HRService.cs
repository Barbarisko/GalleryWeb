using AutoMapper;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryDAL.Entities;
using GalleryDAL.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Services
{
    public class HRService:IHRService
    {
		private readonly IUnitOfWork _unitOfWork;
		IMapper _mapper;

		public HRService(IUnitOfWork unitOfWork, IMapper mapper)
		{
			_unitOfWork = unitOfWork;
			_mapper = mapper;
		}

		public IEnumerable<CityModel> GetAllCities()
		{
			IEnumerable<City> cityEntities = _unitOfWork.CityRepository.GetAll();
			return _mapper.Map<IEnumerable<CityModel>>(cityEntities);
		}
		public IEnumerable<CountryModel> GetAllCountries()
		{
			IEnumerable<Country> countEntities = _unitOfWork.CountryRepository.GetAll();
			return _mapper.Map<IEnumerable<CountryModel>>(countEntities);
		}
		public CityModel GetCityById(int id)
		{
			City entity = _unitOfWork.CityRepository.Get(id);

			if (entity != null)
			{
				return _mapper.Map<CityModel>(entity);
			}
			return null;
		}
		public CountryModel GetCountryById(int id)
		{
			Country entity = _unitOfWork.CountryRepository.Get(id);

			if (entity != null)
			{
				return _mapper.Map<CountryModel>(entity);
			}
			return null;
		}


		public EmployeeModel GetEmployeeById(int id)
		{
			Employee entity = _unitOfWork.EmployeeRepository.Get(id);

			if (entity != null)
			{
				return _mapper.Map<EmployeeModel>(entity);
			}
			return null;
		}

		public IEnumerable<EmployeeModel> GetAllEmployees()
		{
			IEnumerable<Employee> eEntities = _unitOfWork.EmployeeRepository.GetAll();
			return _mapper.Map<IEnumerable<EmployeeModel>>(eEntities);
		}

        public void AddEmployee(EmployeeModel employee)
        {
            _unitOfWork.EmployeeRepository.Add(
                _mapper.Map<Employee>(employee));
            _unitOfWork.Save();
        }
        public void DeleteEmployee(int id)
        {
		    _unitOfWork.EmployeeRepository.Delete(id);
            _unitOfWork.Save();
        }


		public IEnumerable<ExhibitPlaceModel> GetAllPlaces()
		{
			IEnumerable<ExhibitPlace> placeEntities = _unitOfWork.ExhibitPlaceRepository.GetAll();
			return _mapper.Map<IEnumerable<ExhibitPlaceModel>>(placeEntities);
		}
		public ExhibitPlaceModel GetPlaceById(int id)
		{
			ExhibitPlace entity = _unitOfWork.ExhibitPlaceRepository.Get(id);

			if (entity != null)
			{
				return _mapper.Map<ExhibitPlaceModel>(entity);
			}
			return null;
		}

	}
}
