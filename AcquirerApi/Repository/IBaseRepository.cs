using System;
using System.Collections.Generic;

namespace AcquirerApi.Repository
{
    public interface IBaseRepository<T>
    {
        ICollection<T> GetAll();

        T Get(long id);

        T Add(T t);

        void Remove(T t);
    }
}
