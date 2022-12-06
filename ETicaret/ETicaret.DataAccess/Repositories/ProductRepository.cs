using ETicaret.DataAccess.Contexts;
using ETicaret.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.DataAccess.Repositories
{
    public class ProductRepository : GenericRepository<Product>
    {
        public List<Product> GetByCategoryId(int categoryId)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                return ctx.Products.Where(p => p.CategoryID == categoryId).ToList();
            }
        }

        public List<Product> GetByRangePrice(decimal max, decimal miin)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                return ctx.Products.Where(p => p.UnitPrice > miin && p.UnitPrice < max).ToList();
            }
        }
    }
}
