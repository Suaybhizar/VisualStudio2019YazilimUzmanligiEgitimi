using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UzaktanEgitimMVC.MvcGiris.Models.Entity;

namespace UzaktanEgitimMVC.MvcGiris.Controllers
{
    public class ProductController : Controller
    {
        //Burada ki View geriye html csss json gibi sayfaları döndürür.
        // action method
        // ActionResult bütün resultların ata tipidir.
        //public JsonResult Index()
        //{
        //    List<Product> products = new List<Product>()
        //    {
        //        new Product()
        //        {
        //            CategoryID=1,
        //            ProductID=1,
        //            ProductName="Elma",
        //            UnitPrice=10
        //        },
        //         new Product()
        //        {
        //            CategoryID=1,
        //            ProductID=2,
        //            ProductName="Armut",
        //            UnitPrice=15
        //        },
        //          new Product()
        //        {
        //            CategoryID=1,
        //            ProductID=3,
        //            ProductName="Ayva",
        //            UnitPrice=20
        //        },
        //          new Product()
        //        {
        //            CategoryID=1,
        //            ProductID=4,
        //            ProductName="Çilek",
        //            UnitPrice=20
        //        },
        //    };

        //    return Json(products); 
        //}

        //----------------------------------------------------------------------------------

        public ViewResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    CategoryID=1,
                    ProductID=1,
                    ProductName="Elma",
                    UnitPrice=10
                },
                 new Product()
                {
                    CategoryID=1,
                    ProductID=2,
                    ProductName="Armut",
                    UnitPrice=15
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=3,
                    ProductName="Ayva",
                    UnitPrice=20
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=4,
                    ProductName="Çilek",
                    UnitPrice=20
                },

            };

            return View(products);
        }

        // QUERYSTRING ILE VERI GONDERİMİ
        //..../product/index2?categoryId=2&productName=elma
        public ViewResult Index2(int categoryId, string productName)
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    CategoryID=1,
                    ProductID=1,
                    ProductName="Elma",
                    UnitPrice=10
                },
                 new Product()
                {
                    CategoryID=1,
                    ProductID=2,
                    ProductName="Armut",
                    UnitPrice=15
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=3,
                    ProductName="Ayva",
                    UnitPrice=20
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=4,
                    ProductName="Çilek",
                    UnitPrice=20
                },
                   new Product()
                {
                    CategoryID=1,
                    ProductID=5,
                    ProductName="Muz",
                    UnitPrice=30
                },
                    new Product()
                {
                    CategoryID=1,
                    ProductID=6,
                    ProductName="Erik",
                    UnitPrice=7
                },
                     new Product()
                {
                    CategoryID=2,
                    ProductID=7,
                    ProductName="Su",
                    UnitPrice=5
                },
                      new Product()
                {
                    CategoryID=2,
                    ProductID=8,
                    ProductName="Portakal Suyu",
                    UnitPrice=15
                },
            };


            products = products
                .Where(x => x.CategoryID == categoryId && x.ProductName.ToLower().Contains(productName.ToLower()))
                .ToList();

            return View(products);
        }

        public ViewResult ProductList()
        {
            List<Product> products = new List<Product>()
            {
                new Product()
                {
                    CategoryID=1,
                    ProductID=1,
                    ProductName="Elma",
                    UnitPrice=10
                },
                 new Product()
                {
                    CategoryID=1,
                    ProductID=2,
                    ProductName="Armut",
                    UnitPrice=15
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=3,
                    ProductName="Ayva",
                    UnitPrice=20
                },
                  new Product()
                {
                    CategoryID=1,
                    ProductID=4,
                    ProductName="Çilek",
                    UnitPrice=20
                },
                   new Product()
                {
                    CategoryID=1,
                    ProductID=5,
                    ProductName="Muz",
                    UnitPrice=30
                },
                    new Product()
                {
                    CategoryID=1,
                    ProductID=6,
                    ProductName="Erik",
                    UnitPrice=7
                },
                     new Product()
                {
                    CategoryID=2,
                    ProductID=7,
                    ProductName="Su",
                    UnitPrice=5
                },
                      new Product()
                {
                    CategoryID=2,
                    ProductID=8,
                    ProductName="Portakal Suyu",
                    UnitPrice=15
                },
            };

            return View(products);
        }

        [HttpGet]
        public ViewResult New()
        {
            return View();
        }

        [HttpPost]
        public ViewResult New(Product product)
        {
            //kendisine gelen veriyi veri tabanına insert edilecek.

            ViewData["message"] = "<div class='alert alert-success'>Ürün Başarıyla Kaydedildi</div>";

            return View();
        }
        //public ViewResult SaveNewProduct(Product product)
        //{
        //    //kendisine gelen veriyi veri tabanına insert edilecek.

        //    return View();

        //}
    }
}
