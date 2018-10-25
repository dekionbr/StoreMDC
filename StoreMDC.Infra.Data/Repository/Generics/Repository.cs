using Microsoft.EntityFrameworkCore;
using StoreMDC.Domain.Interfaces.Repository.Generics;
using StoreMDC.Infra.Data.Context;
using System;
using System.Linq;

namespace StoreMDC.Infra.Data.Repository.Generics
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly StoreMDCContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(StoreMDCContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
            SaveChanges();
        }

        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return DbSet;
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
            SaveChanges();
        }

        public virtual void Remove(int id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
