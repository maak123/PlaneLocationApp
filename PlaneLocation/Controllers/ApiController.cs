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

        // GET: api
        public async Task<IActionResult> Index()
        {
            return Ok(await _planeDetailService.GetAllAsync());
        }

        // GET: api/Details/5
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

        // api/Create
        [HttpPost, ActionName("Create")]
        public async Task<IActionResult> Create([FromBody]PlaneDetailsResource planeDetails)
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

       

       // api/Edit/5
        [HttpPost, ActionName("Edit")]
        
        public async Task<IActionResult> Edit([FromBody]PlaneDetailsResource planeDetails)
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

        // POST: api/Delete/5
        [HttpPost, ActionName("Delete")]
        // [ValidateAntiForgeryToken]
        public async Task<bool> DeleteConfirmed(int id)
        {
            return await _planeDetailService.RemoveAsync(id);
        }

    }
}