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
        public ArtistsController(ILogger<HomeController> logger, IArtistService artistsService,
            IExhibitionService exhibitionService, ICurrentExhibitionService currentExhibitionService, IPictureService pictureService)
        {
            _logger = logger;
            this.artistsService = artistsService;
            this.pictureService = pictureService;
        }
        public IActionResult Artists()
        {
            Artists model = new Artists(artistsService.GetAllArtists().ToList());
            return View(model);
        }
        public IActionResult ShowArtist(int artistId)
        {
            SingleArtist model = new SingleArtist(artistsService.GetArtistById(artistId),
                pictureService.GetAllPicsFromArtist(artistId));
            return View(model);
        }
    }
}
