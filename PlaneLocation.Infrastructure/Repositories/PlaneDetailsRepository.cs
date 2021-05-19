
using PlaneLocation.Domain.PlaneDetails;
using PlaneLocation.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLocation.Infrastructure.Repositories
{
   public class PlaneDetailsRepository : GenericRepository<PlaneDetails>, IPlaneDetailsRepository
    {
        public PlaneDetailsRepository(AppDBContext context) : base(context)
        {
        }

        public AppDBContext AppDbContext => context as AppDBContext;

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}