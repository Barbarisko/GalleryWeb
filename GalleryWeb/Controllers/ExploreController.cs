using GalleryBLL.Interfaces;
using GalleryBLL.Models;
using GalleryWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalleryWeb.Controllers
{
    public class ExploreController : Controller
    {
        private readonly ILogger<ExploreController> _logger;
        ICurrentExhibitionService currentExhibitionService;
        IExhibitionService exhibitionService;
        IPictureService pictureService;
        public ExploreController(ILogger<ExploreController> logger,
            ICurrentExhibitionService currentExhibitionService, IExhibitionService exhibitionService, IPictureService pictureService)
        {
            _logger = logger;
            this.currentExhibitionService = currentExhibitionService;
            this.exhibitionService = exhibitionService;
            this.pictureService = pictureService;
        }
        public IActionResult ShowCExhibition(int eId, int ceId)
        {
            SingleExh model = new SingleExh(exhibitionService.GetExhById(eId), currentExhibitionService.GetCurExhById(ceId), 
                currentExhibitionService.GetAllPicsFromExhibition(ceId));
            return View(model);
        }
        
        public IActionResult ShowPicture(int picId)
        {
            return View();
        }
        public IActionResult Collections()
        {
            Pictures model = new Pictures(pictureService.GetAllPics().ToList());
            return View(model);
        }

    }
}
