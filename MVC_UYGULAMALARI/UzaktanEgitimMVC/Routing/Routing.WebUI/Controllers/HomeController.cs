using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Routing.WebUI.Models;
using Routing.WebUI.Models.Entity;
using Routing.WebUI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.WebUI.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index(int catId)
        {
            NorthwndContext ctx = new NorthwndContext();
            IndexVm vm = new IndexVm();

            vm.Categories = ctx.Categories.ToList();
            if (catId != 0)
            {
                vm.Products = ctx.Products.Where(prd => prd.CategoryID == catId).ToList();
            }

          

            return View(vm);
        }


    }
}
