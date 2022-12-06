using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreshShop.DataAccess.Abstract
{
    public interface IRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(int id);
        int Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);


    }
}