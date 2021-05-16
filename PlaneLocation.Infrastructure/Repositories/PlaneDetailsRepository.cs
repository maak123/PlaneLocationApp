
using PlaneLocation.Domain.PlaneDetails;
using PlaneLocation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlaneLocation.Infrastructure.Repositories
{
    class PlaneDetailsRepository : GenericRepository<PlaneDetails>, IPlaneDetailsRepository
    {
        public PlaneDetailsRepository(AppDBContext context) : base(context)
        {
        }

        public AppDBContext AppDbContext => context as AppDBContext;
    }
}