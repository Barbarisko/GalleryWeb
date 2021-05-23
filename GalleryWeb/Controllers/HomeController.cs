using GalleryBLL.Interfaces;
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

        public HomeController(ILogger<HomeController> logger, IArtistService artistsService)
        {
            _logger = logger;
            this.artistsService = artistsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Artists()
        {
            Artists model = new Artists(artistsService.GetAllCategories().ToList());
            return View(model);
        }
        public IActionResult Collections()
        {
            return View();
        }
        public IActionResult Cart()
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
