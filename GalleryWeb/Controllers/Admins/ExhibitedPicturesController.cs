using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GalleryDAL;
using GalleryDAL.Entities;
using GalleryWeb.Models;
using GalleryBLL.Interfaces;
using GalleryBLL.Models;

namespace GalleryWeb.Controllers.Admins
{
    public class ExhibitedPicturesController : Controller
    {
        private readonly GalleryDbContext _context;
        ICurrentExhibitionService currentExhibitionService;
        IPictureService pictureService;
        IExhibitionService exhibitionService;
        public ExhibitedPicturesController(GalleryDbContext context, ICurrentExhibitionService currentExhibitionService, IPictureService pictureService, IExhibitionService exhibitionService)
        {
            _context = context;
            this.currentExhibitionService = currentExhibitionService;
            this.pictureService = pictureService;
            this.exhibitionService = exhibitionService;
        }

        // GET: ExhibitedPictures
        public async Task<IActionResult> Index()
        {
            var list = currentExhibitionService.GetAllExhPics().ToList();
            foreach (ExhibitedPictureModel c in list)
            {
                c.CurrentExhibition = currentExhibitionService.GetCurExhById(c.IdCurrExh);
                c.CurrentExhibition.Exhibition = exhibitionService.GetExhById(c.CurrentExhibition.IdExh);
                c.Picture = pictureService.GetPicById(c.IdPicture);
            }
            ExhPicModel model = new ExhPicModel(list);
            return View(model);
        }

        // GET: ExhibitedPictures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibitedPicture = await _context.ExhibitedPictures
                .Include(e => e.CurrExh)
                .Include(e => e.Picture)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exhibitedPicture == null)
            {
                return NotFound();
            }

            return View(exhibitedPicture);
        }

        // GET: ExhibitedPictures/Create
        public IActionResult Create()
        {
            ViewData["IdCurrExh"] = new SelectList(_context.CurrentExhibitions, "Id", "Name");
            ViewData["IdPicture"] = new SelectList(_context.Pictures, "Id", "Name");
            return View();
        }

        // POST: ExhibitedPictures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdCurrExh,IdPicture,Room,Id")] ExhibitedPicture exhibitedPicture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exhibitedPicture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCurrExh"] = new SelectList(_context.CurrentExhibitions, "Id", "Name", exhibitedPicture.IdCurrExh);
            ViewData["IdPicture"] = new SelectList(_context.Pictures, "Id", "Name", exhibitedPicture.IdPicture);
            return View(exhibitedPicture);
        }

        // GET: ExhibitedPictures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibitedPicture = await _context.ExhibitedPictures.FindAsync(id);
            if (exhibitedPicture == null)
            {
                return NotFound();
            }
            ViewData["IdCurrExh"] = new SelectList(_context.CurrentExhibitions, "Id", "Name", exhibitedPicture.IdCurrExh);
            ViewData["IdPicture"] = new SelectList(_context.Pictures, "Id", "Name", exhibitedPicture.IdPicture);
            return View(exhibitedPicture);
        }

        // POST: ExhibitedPictures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCurrExh,IdPicture,Room,Id")] ExhibitedPicture exhibitedPicture)
        {
            if (id != exhibitedPicture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exhibitedPicture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExhibitedPictureExists(exhibitedPicture.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdCurrExh"] = new SelectList(_context.CurrentExhibitions, "Id", "Name", exhibitedPicture.IdCurrExh);
            ViewData["IdPicture"] = new SelectList(_context.Pictures, "Id", "Name", exhibitedPicture.IdPicture);
            return View(exhibitedPicture);
        }

        // GET: ExhibitedPictures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibitedPicture = await _context.ExhibitedPictures
                .Include(e => e.CurrExh)
                .Include(e => e.Picture)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exhibitedPicture == null)
            {
                return NotFound();
            }

            return View(exhibitedPicture);
        }

        // POST: ExhibitedPictures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exhibitedPicture = await _context.ExhibitedPictures.FindAsync(id);
            _context.ExhibitedPictures.Remove(exhibitedPicture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExhibitedPictureExists(int id)
        {
            return _context.ExhibitedPictures.Any(e => e.Id == id);
        }
    }
}
