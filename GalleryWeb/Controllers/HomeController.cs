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
        IExhibitionService exhibitionService;
        ICurrentExhibitionService currentExhibitionService;
        public HomeController(ILogger<HomeController> logger, IExhibitionService exhibitionService, 
            ICurrentExhibitionService currentExhibitionService)
        {
            _logger = logger;
            this.exhibitionService = exhibitionService;
            this.currentExhibitionService = currentExhibitionService;
        }

        public IActionResult Index()
        {
            HomePageModel model = new HomePageModel(exhibitionService.GetAllExhibitions().ToList(),
                                                    currentExhibitionService.GetAllCurrentExhibitions().ToList()); 
                                                    //exhibitionService.GetAllNews().ToList());
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
