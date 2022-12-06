using ETicaret.Business;
using ETicaret.Model.Dtos;
using ETicaret.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ETicaret.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            HomeIndexDto homeIndexDto = new HomeIndexDto(); 

            ProductBs productBs = new ProductBs();
            CategoryBs categoryBs = new CategoryBs();

            homeIndexDto.Products = productBs.GetProducts("Category");
            homeIndexDto.Categories = categoryBs.GetCategories();

            return View(homeIndexDto);
        }

       
    }
}
