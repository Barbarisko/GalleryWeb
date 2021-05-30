using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GalleryDAL;
using GalleryDAL.Entities;
using GalleryBLL.Interfaces;

namespace GalleryWeb.Controllers.Admins
{
    public class CurrentExhibitionsAdminController : Controller
    {
        private readonly GalleryDbContext _context;
        ICurrentExhibitionService currentExhibitionService;
        public CurrentExhibitionsAdminController(GalleryDbContext context, ICurrentExhibitionService currentExhibitionService)
        {
            _context = context;
            this.currentExhibitionService = currentExhibitionService;
        }

        // GET: CurrentExhibitions
        public async Task<IActionResult> Index()
        {
            var galleryDbContext = _context.CurrentExhibitions.Include(c => c.Employee).Include(c => c.Exh).Include(c => c.ExhPlace);
            //var list = currentExhibitionService.GetAllCurrentExhibitions().ToList();
            //foreach (CurrentExhibitionModel c in list)
            //{
            //    currentExhibitionService.CountEstimatePrice(c.Id);
            //}
            return View(await galleryDbContext.ToListAsync());
        }

        // GET: CurrentExhibitions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentExhibition = await _context.CurrentExhibitions
                .Include(c => c.Employee)
                .Include(c => c.Exh)
                .Include(c => c.ExhPlace)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (currentExhibition == null)
            {
                return NotFound();
            }

            return View(currentExhibition);
        }

        // GET: CurrentExhibitions/Create
        public IActionResult Create()
        {
            ViewData["IdEmployee"] = new SelectList(_context.Employees, "Id", "LastName");
            ViewData["IdExh"] = new SelectList(_context.Exhibitions, "Id", "Name");
            ViewData["IdExhPlace"] = new SelectList(_context.ExhibitPlaces, "Id", "Id");
            return View();
        }

        // POST: CurrentExhibitions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEmployee,IdExh,IdExhPlace,DateBegin,DateEnd,maxTicketQuantity,EstimatedPrice,Tag,Id")] CurrentExhibition currentExhibition)
        {
            if (ModelState.IsValid)
            {
                _context.Add(currentExhibition);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdEmployee"] = new SelectList(_context.Employees, "Id", "LastName", currentExhibition.IdEmployee);
            ViewData["IdExh"] = new SelectList(_context.Exhibitions, "Id", "Name", currentExhibition.IdExh);
            ViewData["IdExhPlace"] = new SelectList(_context.ExhibitPlaces, "Id", "Id", currentExhibition.IdExhPlace);
            return View(currentExhibition);
        }

        // GET: CurrentExhibitions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentExhibition = await _context.CurrentExhibitions.FindAsync(id);
            if (currentExhibition == null)
            {
                return NotFound();
            }
            ViewData["IdEmployee"] = new SelectList(_context.Employees, "Id", "LastName", currentExhibition.IdEmployee);
            ViewData["IdExh"] = new SelectList(_context.Exhibitions, "Id", "Name", currentExhibition.IdExh);
            ViewData["IdExhPlace"] = new SelectList(_context.ExhibitPlaces, "Id", "Id", currentExhibition.IdExhPlace);
            return View(currentExhibition);
        }

        // POST: CurrentExhibitions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEmployee,IdExh,IdExhPlace,DateBegin,DateEnd,maxTicketQuantity,EstimatedPrice,Tag,Id")] CurrentExhibition currentExhibition)
        {
            if (id != currentExhibition.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(currentExhibition);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CurrentExhibitionExists(currentExhibition.Id))
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
            ViewData["IdEmployee"] = new SelectList(_context.Employees, "Id", "LastName", currentExhibition.IdEmployee);
            ViewData["IdExh"] = new SelectList(_context.Exhibitions, "Id", "Name", currentExhibition.IdExh);
            ViewData["IdExhPlace"] = new SelectList(_context.ExhibitPlaces, "Id", "Id", currentExhibition.IdExhPlace);
            return View(currentExhibition);
        }

        // GET: CurrentExhibitions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentExhibition = await _context.CurrentExhibitions
                .Include(c => c.Employee)
                .Include(c => c.Exh)
                .Include(c => c.ExhPlace)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (currentExhibition == null)
            {
                return NotFound();
            }

            return View(currentExhibition);
        }

        // POST: CurrentExhibitions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var currentExhibition = await _context.CurrentExhibitions.FindAsync(id);
            _context.CurrentExhibitions.Remove(currentExhibition);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CurrentExhibitionExists(int id)
        {
            return _context.CurrentExhibitions.Any(e => e.Id == id);
        }
    }
}
