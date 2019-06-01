using System.Collections.Generic;
using AcquirerApi.Models;

namespace AcquirerApi.Repositories
{
    public interface IAcquirerRepository : IBaseRepository<Acquirer>
    {
        Acquirer Get(long id);
        Acquirer GetByName(string name);
    }
}