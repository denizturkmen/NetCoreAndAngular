using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BackendApi.DataAccessLayer.Abstract
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        public TEntity GetById(int id);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);

    }
}
