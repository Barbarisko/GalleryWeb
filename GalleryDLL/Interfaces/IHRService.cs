using GalleryBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GalleryBLL.Interfaces
{
    public interface  IHRService
    {
        IEnumerable<CityModel> GetAllCities();
        CityModel GetCityById(int id);

        IEnumerable<CountryModel> GetAllCountries();
        public CountryModel GetCountryById(int id);

        EmployeeModel GetEmployeeById(int id);
        void AddEmployee(EmployeeModel employee);
        void DeleteEmployee(int id);

        IEnumerable<ExhibitPlaceModel> GetAllPlaces();
        ExhibitPlaceModel GetPlaceById(int id);
    }
}
