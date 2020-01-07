using System;
using System.Collections.Generic;
using System.Text;

namespace WMBLib.Repositories
{
    public interface IRepository <T>
    {
        T RetrieveById(int id);
        List<T> RetrieveAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
