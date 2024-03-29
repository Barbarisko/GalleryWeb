﻿using GalleryBLL.Interfaces;
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
        IArtistService artistService;
        IHRService hRService;
        public ExploreController(ILogger<ExploreController> logger,
            ICurrentExhibitionService currentExhibitionService, IExhibitionService exhibitionService,
            IPictureService pictureService, IArtistService artistService, IHRService hRService)
        {
            _logger = logger;
            this.currentExhibitionService = currentExhibitionService;
            this.exhibitionService = exhibitionService;
            this.pictureService = pictureService;
            this.artistService = artistService;
            this.hRService = hRService;
        }
        public IActionResult ShowCExhibition(int eId, int ceId)
        {
            SingleExh model = new SingleExh(exhibitionService.GetExhById(eId), currentExhibitionService.GetCurExhById(ceId), 
                currentExhibitionService.GetAllPicsFromExhibition(ceId), hRService.GetPlaceById(currentExhibitionService.GetCurExhById(ceId).IdExhPlace)
                , hRService.GetCityById(hRService.GetPlaceById(currentExhibitionService.GetCurExhById(ceId).IdExhPlace).IdCity));
            return View(model);
        }
        
        public IActionResult ShowPicture(int picId)
        {
            var pic = pictureService.GetPicById(picId);
            SinglePicture model = new SinglePicture(pic);

            model.Picture.Artist = artistService.GetArtistById(pic.IdArtist);
            model.Picture.Technique = pictureService.GetTechById(pic.IdTechnique);
            //var art = artistService.GetArtistById(pic.IdArtist);
            //var tech = pictureService.GetTechById(pic.IdTechnique);
            //SinglePicture model = new SinglePicture(pic, art, tech);
            return View(model);
        }
        public IActionResult Collections()
        {
            Pictures model = new Pictures(pictureService.GetAllPics().ToList(), 
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());
            return View(model);
        }
        public IActionResult SortAZ()
        {
            Pictures model = new Pictures(pictureService.GetAllPics(), 
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());            
            model.pics = pictureService.SortPicturesAZ(model.pics); 
            return View("Collections", model);
        }
        public IActionResult SortZA()
        {
            Pictures model = new Pictures(pictureService.GetAllPics(),
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());            
            model.pics = pictureService.SortPicturesZA(model.pics); 
            return View("Collections", model);
        }
        public IActionResult FilterByGenre(string genreName)
        {
            Pictures jopa = new Pictures(pictureService.FilterByGenre(pictureService.GetAllPics(), genreName), 
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());
            //model.pics = pictureService.FilterByGenre(model.pics, genreName); 
            return View("Collections", jopa);
        }
        public IActionResult FilterByTechnique(string genreName)
        {
            Pictures jopa = new Pictures(pictureService.FilterByGenre(pictureService.GetAllPics(), genreName), 
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());
            //model.pics = pictureService.FilterByGenre(model.pics, genreName); 
            return View("Collections", jopa);
        }
        public IActionResult FilterByArtist(string genreName)
        {
            Pictures jopa = new Pictures(pictureService.FilterByGenre(pictureService.GetAllPics(), genreName), 
                artistService.GetAllArtists().ToList(), pictureService.GetAllTechniqes().ToList());
            //model.pics = pictureService.FilterByGenre(model.pics, genreName); 
            return View("Collections", jopa);
        }

    }
}
