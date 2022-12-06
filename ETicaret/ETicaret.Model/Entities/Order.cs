using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Entities
{
    public class Order : IEntity
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Freight { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
    }
}
