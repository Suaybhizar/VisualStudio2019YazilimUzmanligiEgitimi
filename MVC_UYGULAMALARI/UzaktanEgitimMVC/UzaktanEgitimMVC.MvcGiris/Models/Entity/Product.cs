using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UzaktanEgitimMVC.MvcGiris.Models.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
