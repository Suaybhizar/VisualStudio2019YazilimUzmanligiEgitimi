using EntityFrameworkCalismalari.MvcWebUI.Models;
using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using EntityFrameworkCalismalari.MvcWebUI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult NewProduct()
        {
            NorthwindContext ctx = new NorthwindContext();


            //NewProductVm vm = new NewProductVm();

            //vm.Categories = ctx.Categories.ToList();
            //vm.Suppliers = ctx.Suppliers.ToList();
            //--------------------------------------------

            NewProductVm vm = new NewProductVm();

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

            vm.NewProduct = new Product();

            return View(vm);
        }
        [HttpPost]
        public IActionResult NewProduct(Product NewProduct)
        {
            NorthwindContext ctx = new NorthwindContext();

            ctx.Products.Add(NewProduct);
            ctx.SaveChanges();


            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {

            NorthwindContext ctx = new NorthwindContext();

            ProductEditVm vm = new ProductEditVm();


            vm.ProductToEdit = ctx.Products.SingleOrDefault(prd => prd.ProductID == id);

            vm.Categories = ctx.Categories.Select(cat => new SelectListItem()
            {
                Text = cat.CategoryName,
                Value = cat.CategoryID.ToString(),
                Selected = cat.CategoryID == vm.ProductToEdit.CategoryId

            }).ToList();

            vm.Categories.Insert(0, new SelectListItem()
            {
                Text = "Seçiniz...",
                Value = "-1"
            });


            vm.Suppliers = ctx.Suppliers.Select(sup => new SelectListItem()
            {
                Text = sup.CompanyName,
                Value = sup.SupplierID.ToString(),
                Selected = sup.SupplierID == vm.ProductToEdit.SupplierID
            }).ToList();

            vm.Suppliers.Insert(0, new SelectListItem()
            {
                Text = "Seçiniz...",
                Value = "-1"
            });


            return View(vm);
        }
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            NorthwindContext ctx = new NorthwindContext();

            Product productToUpdate = ctx.Products.SingleOrDefault(prd => prd.ProductID == product.ProductID);

            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.Discontinued = product.Discontinued;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.QuantityPerUnit = product.QuantityPerUnit;
            productToUpdate.SupplierID = product.SupplierID;
            productToUpdate.UnitPrice = product.UnitPrice;

            ctx.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            NorthwindContext ctx = new NorthwindContext();
            Product productToDelete = ctx.Products.SingleOrDefault(prd => prd.ProductID == id);


            return View(productToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Product product)
        {
            NorthwindContext ctx = new NorthwindContext();
            Product pr = ctx.Products.SingleOrDefault(prd => prd.ProductID == product.ProductID);

            ctx.Products.Remove(pr);
            ctx.SaveChanges();


            return RedirectToAction("Index", "Home");
        }
    }

}
