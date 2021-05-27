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
    public class ExhibitionsController : Controller
    {
        private readonly GalleryDbContext _context;

        public ExhibitionsController(GalleryDbContext context)
        {
            _context = context;
        }

        // GET: Exhibitions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exhibitions.ToListAsync());
        }

        // GET: Exhibitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exhibition == null)
            {
                return NotFound();
            }

            return View(exhibition);
        }

        // GET: Exhibitions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Exhibitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Price,Description,Id")] Exhibition exhibition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exhibition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exhibition);
        }

        // GET: Exhibitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibitions.FindAsync(id);
            if (exhibition == null)
            {
                return NotFound();
            }
            return View(exhibition);
        }

        // POST: Exhibitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Price,Description,Id")] Exhibition exhibition)
        {
            if (id != exhibition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exhibition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExhibitionExists(exhibition.Id))
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
            return View(exhibition);
        }

        // GET: Exhibitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exhibition = await _context.Exhibitions
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exhibition == null)
            {
                return NotFound();
            }

            return View(exhibition);
        }

        // POST: Exhibitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exhibition = await _context.Exhibitions.FindAsync(id);
            _context.Exhibitions.Remove(exhibition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExhibitionExists(int id)
        {
            return _context.Exhibitions.Any(e => e.Id == id);
        }
    }
}
