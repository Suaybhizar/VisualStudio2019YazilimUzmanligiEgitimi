using FreshShop.Model.Entity;
using FreshShop.MvcWebUI.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FreshShop.MvcWebUI.ActionFilters
{
    public class ActiveManagerActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Manager activeManager = context.HttpContext.Session.GetObject<Manager>("ActiveManager");
            if (activeManager != null)
                return;
            context.Result = new RedirectResult("/admin");
        }
    }
}
