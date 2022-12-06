using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Concrete
{
    public class ProductPhotoBs : IProductPhotoBs
    {
        private readonly IProductPhotoRepository _repo;
        public ProductPhotoBs(IProductPhotoRepository repo)
        {
            _repo = repo;
        }

        public void Delete(ProductPhoto entity)
        {
            //LOGLAMA
            //CACHLEME
            //VALIDATION
            _repo.Delete(entity);
        }

        public ProductPhoto Get(Expression<Func<ProductPhoto, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<ProductPhoto> GetAll(Expression<Func<ProductPhoto, bool>> filter = null)
        {
            return _repo.GetAll(filter);
        }



        public ProductPhoto GetById(int id)
        {
            return _repo.GetById(id);
        }



        public int Insert(ProductPhoto entity)
        {
            //LOGLAMA
            //CACHLEME
            //VALIDATION
            return _repo.Insert(entity);
        }

        public void Update(ProductPhoto entity)
        {
            _repo.Update(entity);
        }
    }
}
