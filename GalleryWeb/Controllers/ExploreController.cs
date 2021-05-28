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
    public class ExploreController : Controller
    {
        private readonly ILogger<ExploreController> _logger;
        ICurrentExhibitionService currentExhibitionService;
        IExhibitionService exhibitionService;
        public ExploreController(ILogger<ExploreController> logger,
            ICurrentExhibitionService currentExhibitionService, IExhibitionService exhibitionService)
        {
            _logger = logger;
            this.currentExhibitionService = currentExhibitionService;
            this.exhibitionService = exhibitionService;
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
            ExhPicModel model = new ExhPicModel(currentExhibitionService.GetAllPicsFromExhibition(2).ToList());
            return View(model);
        }

    }
}
