using FreshShop.Business.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace FreshShop.Business.Abstract
{
    public interface IProductBs
    {
        List<Product> GetAll(Expression<Func<Product, bool>> filter = null);
        Product Get(Expression<Func<Product, bool>> filter);
        Product GetById(int id);
        int Insert(Product entity);
        void Update(Product entity);
        void Delete(Product entity);

        List<Product> GetByCategoryId(int categoryId);
        List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice);
    }
}