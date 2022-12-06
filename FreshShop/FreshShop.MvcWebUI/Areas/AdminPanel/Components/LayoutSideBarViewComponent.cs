using FreshShop.Model.Entity;
using FreshShop.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.Areas.AdminPanel.Components
{
    public class LayoutSideBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Manager activeManager = HttpContext.Session.GetObject<Manager>("ActiveManager");

            return View(activeManager);
        }
    }
}
