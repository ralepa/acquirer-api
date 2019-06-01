using System;
using System.Collections.Generic;
using AcquirerApi.Responses;

namespace AcquirerApi.Services
{
    public interface IAcquirerService
    {
        IList<AcquirerResponse> GetAll();

    }
}
