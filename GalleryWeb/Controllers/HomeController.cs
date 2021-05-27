using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IArtistService artistsService;
        IExhibitionService exhibitionService;
        ICurrentExhibitionService currentExhibitionService;
        IPictureService pictureService;
        public HomeController(ILogger<HomeController> logger, IArtistService artistsService, 
            IExhibitionService exhibitionService, IPictureService pictureService, ICurrentExhibitionService currentExhibitionService)
        {
            _logger = logger;
            this.artistsService = artistsService;
            this.exhibitionService = exhibitionService;
            this.pictureService = pictureService;
            this.currentExhibitionService = currentExhibitionService;
        }

        public IActionResult Index()
        {
            Exhibitions model = new Exhibitions(exhibitionService.GetAllExhibitions().ToList());
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Collections()
        {
            ExhPicModel model = new ExhPicModel(currentExhibitionService.GetAllPicsFromExhibition(2).ToList());
            return View(model);
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult ShowPicture(int picId)
        {

            return View();
        }
        public IActionResult ShowCExhibition(int eId)
        {
            SingleExh model = new SingleExh(exhibitionService.GetExhById(eId));
            return View(model);
        }
        public IActionResult ShowArtist(int artistId)
        {
            SingleArtist model = new SingleArtist(artistsService.GetArtistById(artistId),
                pictureService.GetAllPicsFromArtist(artistId));
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
