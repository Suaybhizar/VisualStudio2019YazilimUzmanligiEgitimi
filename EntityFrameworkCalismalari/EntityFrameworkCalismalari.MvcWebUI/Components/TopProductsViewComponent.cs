using EntityFrameworkCalismalari.MvcWebUI.Models;
using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Components
{
    public class TopProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int count)
        {
            NorthwindContext ctx = new NorthwindContext();
            List<Product> products = ctx.Products.Take(count).ToList();

            return View(products);
        }
    }
}
