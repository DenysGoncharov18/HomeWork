using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDAL.EF;
using WebAppDAL.Entities;
using WebAppDAL.Interfaces;

namespace WebAppDAL.Repositories
{
    abstract class Repository<T> : IRepository<T> where T : class
    {
        protected HotelContext db;
        protected DbSet<T> dbSet;
        public Repository(HotelContext db,DbSet<T> dbSet)
        {
            this.db = db;
            this.dbSet = dbSet;
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet;
        }
        public T Get(Guid id)
        {
            return this.dbSet.Find(id);
        }
        public void Create(T item)
        {
            this.dbSet.Add(item);
        }
        public void Update(T item)
        {
            this.db.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
        public void Delete(Guid id)
        {
            var item = Get(id);
            if (item != null)
            {
                this.dbSet.Remove(item);
            }
        }
    }
}
