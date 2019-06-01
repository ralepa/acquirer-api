using System;
using System.Collections.Generic;

namespace AcquirerApi.Repositories
{
    public interface IBaseRepository<T>
    {
        ICollection<T> GetAll();

        T Add(T t);

        void Remove(T t);
    }
}
