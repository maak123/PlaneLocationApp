using PlaneLocation.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLocation.Domain.PlaneDetails
{
    public interface IPlaneDetailsRepository:IGenericRepository<PlaneDetails>
    {
        public Task CompleteAsync();
    }
}
