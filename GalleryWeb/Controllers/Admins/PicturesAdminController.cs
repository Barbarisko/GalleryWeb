using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GalleryDAL;
using GalleryDAL.Entities;

namespace GalleryWeb.Controllers
{
    public class PicturesAdminController : Controller
    {
        private readonly GalleryDbContext _context;

        public PicturesAdminController(GalleryDbContext context)
        {
            _context = context;
        }

        // GET: PicturesAdmin
        public async Task<IActionResult> Index()
        {
            var galleryDbContext = _context.Pictures.Include(p => p.Artist).Include(p => p.Technique);
            return View(await galleryDbContext.ToListAsync());
        }

        // GET: PicturesAdmin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures
                .Include(p => p.Artist)
                .Include(p => p.Technique)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture);
        }

        // GET: PicturesAdmin/Create
        public IActionResult Create()
        {
            ViewData["IdArtist"] = new SelectList(_context.Artists, "Id", "Name");
            ViewData["IdTechnique"] = new SelectList(_context.Techniques, "Id", "Name");
            return View();
        }

        // POST: PicturesAdmin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,CreateDate,Price,Genre,AddInfo,IdArtist,IdTechnique,Url,Id")] Picture picture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(picture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdArtist"] = new SelectList(_context.Artists, "Id", "Name", picture.IdArtist);
            ViewData["IdTechnique"] = new SelectList(_context.Techniques, "Id", "Name", picture.IdTechnique);
            return View(picture);
        }

        // GET: PicturesAdmin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures.FindAsync(id);
            if (picture == null)
            {
                return NotFound();
            }
            ViewData["IdArtist"] = new SelectList(_context.Artists, "Id", "Name", picture.IdArtist);
            ViewData["IdTechnique"] = new SelectList(_context.Techniques, "Id", "Name", picture.IdTechnique);
            return View(picture);
        }

        // POST: PicturesAdmin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,CreateDate,Price,Genre,AddInfo,IdArtist,IdTechnique,Url,Id")] Picture picture)
        {
            if (id != picture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(picture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PictureExists(picture.Id))
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
            ViewData["IdArtist"] = new SelectList(_context.Artists, "Id", "Name", picture.IdArtist);
            ViewData["IdTechnique"] = new SelectList(_context.Techniques, "Id", "Name", picture.IdTechnique);
            return View(picture);
        }

        // GET: PicturesAdmin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var picture = await _context.Pictures
                .Include(p => p.Artist)
                .Include(p => p.Technique)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (picture == null)
            {
                return NotFound();
            }

            return View(picture);
        }

        // POST: PicturesAdmin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var picture = await _context.Pictures.FindAsync(id);
            _context.Pictures.Remove(picture);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PictureExists(int id)
        {
            return _context.Pictures.Any(e => e.Id == id);
        }
    }
}
