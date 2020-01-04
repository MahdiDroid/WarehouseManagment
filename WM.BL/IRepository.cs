using System;
using System.Collections.Generic;
using System.Text;

namespace WM.BL
{
    public interface IRepository <T>
    {
        T RetriveById(int id);
        List<T> RetrieveAll();
        void Add(T entity);

    }
}
