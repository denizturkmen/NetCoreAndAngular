using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BackendApi.DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class
        where TContext : DbContext, new()

    {
        public virtual void Create(TEntity entity)
        {
            using (var context = new DataContext())
            {
               
                context.Set<TEntity>().Add(entity);
                context.SaveChanges();
            }
        }

        public virtual void Delete(TEntity entity)
        {
            using (var context = new DataContext())
            {
               
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

 
        public virtual void Update(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }


        public virtual List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }
        
        public virtual TEntity GetById(int id)
        {
            using (var context = new DataContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

     
    }
}
