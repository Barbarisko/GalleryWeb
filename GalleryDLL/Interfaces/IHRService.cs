using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface  IHRService
    {
        IEnumerable<CityModel> GetAllCities();
        public CityModel GetCityById(int id);

        IEnumerable<CountryModel> GetAllCountries();
        public CountryModel GetCountryById(int id);

        EmployeeModel GetEmployeeById(int id);
        void AddEmployee(EmployeeModel employee);
        public void DeleteEmployee(int id);

        public IEnumerable<ExhibitPlaceModel> GetAllPlaces();
        public ExhibitPlaceModel GetPlaceById(int id);
    }
}
