using Routing.WebUI.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.WebUI.Models.ViewModels
{
    public class IndexVm
    {
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
    }
}
