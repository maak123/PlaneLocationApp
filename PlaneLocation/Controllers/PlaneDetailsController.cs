using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlaneLocation.Data;
using PlaneLocation.Models;

namespace PlaneLocation.Controllers
{
    public class PlaneDetailsController : Controller
    {
        private readonly PlaneDetailsContext _context;

        public PlaneDetailsController(PlaneDetailsContext context)
        {
            _context = context;
        }

        // GET: PlaneDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.PlaneDetails.ToListAsync());
        }

        // GET: PlaneDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeDetails = await _context.PlaneDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planeDetails == null)
            {
                return NotFound();
            }

            return View(planeDetails);
        }

        // GET: PlaneDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// create plane
        /// </summary>
        /// <param name="planeDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Make,Model,Registration,Location,DateAndTime,ImagePath")] PlaneDetails planeDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(planeDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(planeDetails);
        }

        // GET: PlaneDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeDetails = await _context.PlaneDetails.FindAsync(id);
            if (planeDetails == null)
            {
                return NotFound();
            }
            return View(planeDetails);
        }

        /// <summary>
        /// PlaneDetails/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="planeDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Make,Model,Registration,Location,DateAndTime,ImagePath")] PlaneDetails planeDetails)
        {
            if (id != planeDetails.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(planeDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaneDetailsExists(planeDetails.Id))
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
            return View(planeDetails);
        }

        /// <summary>
        /// PlaneDetails/Delete/5
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeDetails = await _context.PlaneDetails
                .FirstOrDefaultAsync(m => m.Id == id);
            if (planeDetails == null)
            {
                return NotFound();
            }

            return View(planeDetails);
        }

        // POST: PlaneDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var planeDetails = await _context.PlaneDetails.FindAsync(id);
            _context.PlaneDetails.Remove(planeDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaneDetailsExists(int id)
        {
            return _context.PlaneDetails.Any(e => e.Id == id);
        }
    }
}
