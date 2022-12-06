using EntityFrameworkCalismalari.MvcWebUI.Models;
using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Components
{
    public class CategoryMenuViewComponent : ViewComponent
    {
       public ViewViewComponentResult Invoke()
        {
            NorthwindContext ctx = new NorthwindContext();
            List<Category> categories = ctx.Categories.ToList();

            return View(categories);
        }
    }
}
