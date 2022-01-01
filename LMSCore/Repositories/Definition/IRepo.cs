using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Repositories
{
    public interface IRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(object id);
        T Insert(T obj);
        T Update(T obj);
        void Delete(object id);
        void Save();
    }
}
