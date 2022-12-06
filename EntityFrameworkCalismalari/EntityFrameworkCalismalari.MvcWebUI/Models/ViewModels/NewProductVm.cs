using EntityFrameworkCalismalari.MvcWebUI.Models.Entity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Models.ViewModels
{
    public class NewProductVm
    {
        //public List<Category> Categories { get; set; }
        //public List<Supplier> Suppliers { get; set; }

        //---------------------------------------------------

        public List<SelectListItem> Categories { get; set; }
        public List<SelectListItem> Suppliers { get; set; }
        public Product NewProduct { get; set; }
    }
}
