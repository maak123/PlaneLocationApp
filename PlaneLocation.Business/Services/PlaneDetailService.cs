using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PlaneLocation.Business.Core;
using PlaneLocation.Domain.PlaneDetails;
using PlaneLocation.Domain.Resources;
using PlaneLocation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLocation.Business.Services
{
    public class PlaneDetailService : IPlaneDetailsService
    {
        private readonly IPlaneDetailsRepository _planeDetailsRepository;
        private readonly IMapper mapper;

        public PlaneDetailService(
            IPlaneDetailsRepository planeDetailsRepository,
            IMapper mapper
            )
        {
            _planeDetailsRepository = planeDetailsRepository;
            this.mapper = mapper;

        }
        public async Task<PlaneDetailsResource> CreateAsync(PlaneDetailsResource planeDetails)
        {
            try
            {
                var updatedDetails = mapper.Map<PlaneDetailsResource, PlaneDetails>(planeDetails);
                var result = await _planeDetailsRepository.AddAsync(updatedDetails);
                await _planeDetailsRepository.CompleteAsync();
                return mapper.Map<PlaneDetails, PlaneDetailsResource>(result);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<PlaneDetailsResource> EditAsync(PlaneDetailsResource planeDetails)
        {
            try
            {
                var updatedDetails = mapper.Map<PlaneDetailsResource, PlaneDetails>(planeDetails);

                var result = await _planeDetailsRepository.UpdateAsync(updatedDetails, updatedDetails.Id);
                await _planeDetailsRepository.CompleteAsync();

                return mapper.Map<PlaneDetails, PlaneDetailsResource>(result);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<IEnumerable<PlaneDetailsResource>> GetAllAsync()
        {
            try
            {
                IEnumerable<PlaneDetails> planeDetails = await _planeDetailsRepository.GetAllAsync();
                return mapper.Map<IEnumerable<PlaneDetails>, IEnumerable<PlaneDetailsResource>>(planeDetails);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<PlaneDetailsResource> GetByIdAsync(int id)
        {
            try
            {
                var planeDetails = await _planeDetailsRepository.FindAsync(ent => ent.Id == id);
                return mapper.Map<PlaneDetails, PlaneDetailsResource>(planeDetails);
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public async Task<bool> RemoveAsync(int id)
        {
            try
            {
                var planeDetails = await _planeDetailsRepository.FindAsync(ent => ent.Id == id);
                _planeDetailsRepository.Delete(planeDetails);
                await _planeDetailsRepository.CompleteAsync();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        public async Task<IEnumerable<PlaneDetailsResource>> SearchAsync(string hint)
        {
            try
            {
                if(hint ==null || hint == "")
                {
                    IEnumerable<PlaneDetails> planeDetails = await _planeDetailsRepository.GetAllAsync();
                    return mapper.Map<IEnumerable<PlaneDetails>, IEnumerable<PlaneDetailsResource>>(planeDetails);

                }
                else
                {
                    var planeDetails = await _planeDetailsRepository.FindAllAsync(ent => ent.Make == hint || ent.Model == hint || ent.Registration == hint);
                    return mapper.Map<IEnumerable<PlaneDetails>, IEnumerable<PlaneDetailsResource>>(planeDetails);

                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
