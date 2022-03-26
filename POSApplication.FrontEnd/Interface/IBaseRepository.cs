using System;
using System.Collections.Generic;

namespace POSApplication.FrontEnd.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        int Save(T obj);
        int Update(T obj);
        int Delete(T obj);
        IList<T> GetAll();
    }
}
