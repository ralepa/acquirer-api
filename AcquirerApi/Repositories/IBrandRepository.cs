using System.Collections.Generic;
using AcquirerApi.Models;

namespace AcquirerApi.Repositories
{
    public interface IBrandRepository : IBaseRepository<Brand>
    {
        Brand Get(long id);
    }
}