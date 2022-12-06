using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Entities
{
    public class Product : IEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
