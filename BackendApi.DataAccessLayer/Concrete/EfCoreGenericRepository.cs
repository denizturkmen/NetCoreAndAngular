using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using BackendApi.DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.DataAccessLayer.Concrete
{
    public class EfCoreGenericRepository<TEntity,TContext> :IRepository<TEntity> where TEntity:class where TContext :DbContext,new ()
    {
        private readonly TContext _context;

        public EfCoreGenericRepository(TContext context)
        {
            _context = context;
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var listEntity= filter == null ? _context.Set<TEntity>().ToList() : _context.Set<TEntity>().Where(filter).ToList();
            return listEntity;
        }

        public TEntity GetById(int id)
        {
            var entity= _context.Set<TEntity>().Find(id);
            return entity;
        }

        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
