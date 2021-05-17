using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlaneLocation.Business.Core;
using PlaneLocation.Domain.Resources;

namespace PlaneLocation.Controllers
{
    public class ApiController : Controller
    {
        private readonly IPlaneDetailsService _planeDetailService;
        public ApiController(IPlaneDetailsService planeDetailService)
        {
            _planeDetailService = planeDetailService;
        }

        // GET: PlaneDetails
        public async Task<IActionResult> Index()
        {
            return Ok(await _planeDetailService.GetAllAsync());
        }

        // GET: PlaneDetails/Details/5
        public async Task<IActionResult> Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var planeDetails = await _planeDetailService.GetByIdAsync(id);
                
            if (planeDetails == null)
            {
                return NotFound();
            }

            return Ok(planeDetails);
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="planeDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlaneDetailsResource planeDetails)
        {
            try
            {
                var result = await _planeDetailService.CreateAsync(planeDetails);

                return Ok(result);

            }catch(Exception e)
            {
                throw; 
            }
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
            try
            {
                var result = await _planeDetailService.EditAsync(planeDetails);

                return Ok(result);

            }
            catch (Exception e)
            {
                throw;
            }
        }

        // POST: PlaneDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<bool> DeleteConfirmed(int id)
        {
            return await _planeDetailService.RemoveAsync(id);
        }

    }
}