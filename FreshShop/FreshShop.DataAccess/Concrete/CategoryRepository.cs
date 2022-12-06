using FreshShop.DataAccess.Abstract;
using FreshShop.DataAccess.Context;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Concrete
{
     public class CategoryRepository : RepositoryBase<Category, FreshShopDbContext>, ICategoryRepository
    {
    }
}
