using ETicaret.Business;
using ETicaret.Model.Dtos;
using ETicaret.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            CategoryBs categoryBs = new CategoryBs();

            return View(categoryBs.GetCategories());
        }
        [HttpPost]
        public IActionResult Add(NewProductDto newProductDto)
        {
            CategoryBs categoryBs = new CategoryBs();

            Product product = new Product();
            product.ProductName = newProductDto.ProductName;
            product.UnitPrice = newProductDto.UnitPrice;
            product.UnitsInStock = newProductDto.UnitsInStock;
            product.CategoryID = newProductDto.CategoryId;

            ProductBs productBs = new ProductBs();
            int rowsAffected = productBs.Add(product);
            ViewBag.Message = "Ürün Başarıyla Kaydedildi";

            return View(categoryBs.GetCategories());
        }
    }
}
