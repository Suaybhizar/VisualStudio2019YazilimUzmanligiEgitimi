using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Model.Entities
{
    public class Category : IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
