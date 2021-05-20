using PlaneLocation.Domain.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PlaneLocation.Business.Core
{
    public interface IPlaneDetailsService
    {
        Task<IEnumerable<PlaneDetailsResource>> GetAllAsync();
        Task<PlaneDetailsResource> GetByIdAsync(int id);
        Task<PlaneDetailsResource> CreateAsync(PlaneDetailsResource device);
        Task<PlaneDetailsResource> EditAsync(PlaneDetailsResource device);
        Task<Boolean> RemoveAsync(int id);
        Task<IEnumerable<PlaneDetailsResource>> SearchAsync(string hint);

    }
}
