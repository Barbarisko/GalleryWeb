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
       
        public ArtistsController(ILogger<HomeController> logger, IArtistService artistsService,
            IExhibitionService exhibitionService, IPictureService pictureService, ICurrentExhibitionService currentExhibitionService)
        {
            _logger = logger;
            this.artistsService = artistsService;
          
        }
        public IActionResult Artists()
        {
            Artists model = new Artists(artistsService.GetAllArtists().ToList());
            return View(model);
        }
    }
}
