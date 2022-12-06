using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Dtos
{
    public class ProductInfoDto:IDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public string CategoryName { get; set; }
        public string SupplierCompanyName { get; set; }
    }
}
