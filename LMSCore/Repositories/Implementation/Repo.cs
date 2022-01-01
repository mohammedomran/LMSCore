using LMSCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCore.Repositories
{
    public class Repo<T> : IRepo<T> where T : class
    {
        private LMSContext Context = null;
        private DbSet<T> table = null;
        public Repo(LMSContext _context)
        {
            Context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public T Insert(T obj)
        {
            table.Add(obj);
            return obj;
        }
        public T Update(T obj)
        {
            table.Attach(obj);
            Context.Entry(obj).State = EntityState.Modified;
            return obj;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
