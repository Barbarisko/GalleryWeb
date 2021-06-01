using GalleryBLL.Interfaces;
using GalleryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IArtistService artistsService;
        IPictureService pictureService;
        IHRService hRService;
        public ArtistsController(ILogger<HomeController> logger, IArtistService artistsService,
            IPictureService pictureService, IHRService hRService)
        {
            _logger = logger;
            this.artistsService = artistsService;
            this.pictureService = pictureService;
            this.hRService = hRService;
        }
        public IActionResult Artists()
        {
            Artists model = new Artists(artistsService.GetAllArtists().ToList(), hRService.GetAllCities().ToList(), hRService.GetAllCountries().ToList());
            return View(model);
        }
        public IActionResult ShowArtist(int artistId)
        {
            SingleArtist model = new SingleArtist(artistsService.GetArtistById(artistId),
                pictureService.GetAllPicsFromArtist(artistId), hRService.GetCityById((int)artistsService.GetArtistById(artistId).IdCity));
            return View(model);
        }
    }
}
