using FreshShop.Model.Entity;
using FreshShop.MvcWebUI.ActionFilters;
using FreshShop.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [ActiveManagerActionFilter]
    public class DashBoardController : Controller
    {
        //ASPECT ORIENTED PROGRAMMINNG (CEPHEYE YONELİK PROGRAMLAMA)
        public IActionResult Index()
        {
            return View();
        }
    }
}
