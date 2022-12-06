using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Dtos
{
    public class NewProductDto
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryId { get; set; }
    }
}
