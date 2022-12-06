using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetByCategoryId(int categoryId);
        List<Product> GetByPriceRange(decimal minPrice, decimal maxPrice);

    }
}