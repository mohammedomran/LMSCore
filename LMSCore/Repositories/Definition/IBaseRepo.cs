using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Repositories
{
    public interface IBaseRepo<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        T Insert(T obj);
        T Update(T obj);
        void Delete(int id);
        void Save();
    }
}
