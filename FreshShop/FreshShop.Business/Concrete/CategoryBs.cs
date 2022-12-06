
using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Concrete
{
    public class CategoryBs : ICategoryBs
    {
        private readonly ICategoryRepository _repo;
        public CategoryBs(ICategoryRepository repo)
        {
            _repo = repo;
        }

        public void Delete(Category entity)
        {
            //LOGLAMA
            //CACHLEME
            //VALIDATION
            _repo.Delete(entity);
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }



        public Category GetById(int id)
        {
            return _repo.GetById(id);
        }



        public int Insert(Category entity)
        {
            //LOGLAMA
            //CACHLEME
            //VALIDATION
            return _repo.Insert(entity);
        }

        public void Update(Category entity)
        {
            _repo.Update(entity);
        }
    }
}
