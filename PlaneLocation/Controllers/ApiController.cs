using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PlaneLocation.Business.Core;
using PlaneLocation.Domain.Resources;

namespace PlaneLocation.Controllers
{
    [Produces("application/json")]
   
    public class ApiController : Controller
    {
        private readonly IPlaneDetailsService _planeDetailService;
        private readonly IConfiguration _configuration;

        public ApiController(IPlaneDetailsService planeDetailService, IConfiguration configuration)
        {
            _planeDetailService = planeDetailService;
            _configuration = configuration;
        }

        // GET: api
        public async Task<IActionResult> Index()
        {
            return Ok(await _planeDetailService.GetAllAsync());
        }

        // GET: api/Details/5
        public async Task<IActionResult> Details(int id)
        {
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

            }
            catch (Exception e)
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

        [HttpPost, ActionName("Delete")]
        public async Task<bool> DeleteConfirmed(int id)
        {
            return await _planeDetailService.RemoveAsync(id);
        }
        [HttpPost, ActionName("Upload")]
        public async Task<IActionResult> OnPostUploadAsync(List<IFormFile> files)
        {
            var filenames = new List<string>();
           
            foreach (var formFile in files)
            {
                if (formFile.Length > 0)
                {
                    string fileName = Path.GetFileNameWithoutExtension(formFile.FileName);
                    string extension = Path.GetExtension(formFile.FileName);
                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;

                    var filePath = Path.Combine(_configuration["StoredFilesPath"],
                        fileName);
                       
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }
                    filenames.Add(fileName);
                }
            }
            var uploadedFileName = filenames.FirstOrDefault();
          
            return Ok(uploadedFileName);
        }

        public async Task<IActionResult> Search([FromQuery]string hint)
        {
            var planeDetails = await _planeDetailService.SearchAsync(hint);

            if (planeDetails == null)
            {
                return NotFound();
            }

            return Ok(planeDetails);
        }

    }
}