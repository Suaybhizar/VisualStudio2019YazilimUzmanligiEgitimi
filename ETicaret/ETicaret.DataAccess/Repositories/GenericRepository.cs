using ETicaret.DataAccess.Contexts;
using Infrastructure.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ETicaret.DataAccess.Repositories
{
    public class GenericRepository<TEntity>
        where TEntity : class, IEntity, new()
    {
        public int Insert(TEntity entity)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                ctx.Set<TEntity>().Add(entity);
                return ctx.SaveChanges();

            }
        }
        public int Delete(TEntity entity)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                ctx.Set<TEntity>().Remove(entity);
                return ctx.SaveChanges();
            }
        }

        public int Update(TEntity entity)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                ctx.Set<TEntity>().Update(entity);
                return ctx.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,params string[] includeList)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();

                if (filter != null)

                    dbSet= dbSet.Where(filter);

                if (includeList!=null)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }

                return dbSet.ToList();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter, params string[] includeList)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                if (includeList != null)
                {
                    for (int i = 0; i < includeList.Length; i++)
                    {
                        dbSet = dbSet.Include(includeList[i]);
                    }
                }
                return dbSet.SingleOrDefault(filter);
            }
        }
       
    }
}
