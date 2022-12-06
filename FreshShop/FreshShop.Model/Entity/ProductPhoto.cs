using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.Model.Entity
{
    public class ProductPhoto : BaseEntity
    {
        public int? ProductId { get; set; }
        public string PhotoPath { get; set; }

        public virtual Product Product { get; set; }
    }
}