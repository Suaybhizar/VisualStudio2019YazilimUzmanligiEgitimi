using EntityFrameworkCalismalari.MvcWebUI.Models;
using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using EntityFrameworkCalismalari.MvcWebUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            NorthwindContext ctx = new NorthwindContext();

            //selectProductID,ProductName... from Products sorgusu çalıştı
            //List<Product> products = ctx.Products.ToList();
            //--------------------------------------------------------------

            HomeIndexVm vm = new HomeIndexVm();

            vm.Products = ctx.Products
                 .Include(prd => prd.Category)
                 .Include(prd => prd.Supplier)
                 .ToList();

            vm.Categories = ctx.Categories.Select(cat => new SelectListItem()
            {
                Text = cat.CategoryName,
                Value = cat.CategoryID.ToString()
            }).ToList();

            vm.Categories.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            vm.Suppliers = ctx.Suppliers.Select(sup => new SelectListItem()
            {
                Text = sup.CompanyName,
                Value = sup.SupplierID.ToString()
            }).ToList();

            vm.Suppliers.Insert(0, new SelectListItem() { Text = "Seçiniz...", Value = "-1" });

            return View(vm);
        }

    }
}
