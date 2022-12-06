using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Entities
{
    public class Customer:IEntity
    {
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
    }
}
