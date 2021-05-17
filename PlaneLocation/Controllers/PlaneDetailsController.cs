using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlaneLocation.Domain.Resources;

namespace PlaneLocation.Controllers
{
    public class PlaneDetailsController : Controller
    {
       

        public PlaneDetailsController()
        {
        }

        // GET: PlaneDetails
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: PlaneDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            return View();
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
        public async Task<IActionResult> Create(PlaneDetailsResource planeDetails)
        {
            
            return View(planeDetails);
        }

        // GET: PlaneDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            
            return View();
        }

        /// <summary>
        /// PlaneDetails/Edit/5
        /// </summary>
        /// <param name="id"></param>
        /// <param name="planeDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(PlaneDetailsResource planeDetails)
        {
            
            if (ModelState.IsValid)
            {
                try
                {
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    throw;
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

           
            return View();
        }

        // POST: PlaneDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            return RedirectToAction(nameof(Index));
        }

      
    }
}
