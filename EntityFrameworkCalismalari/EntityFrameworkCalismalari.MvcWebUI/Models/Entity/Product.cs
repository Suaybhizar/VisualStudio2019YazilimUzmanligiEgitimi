using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Models.Entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int? CategoryId { get; set; } //NULL olabilecek kolonlar için soru işareti eklenmelidir.
        public int? SupplierID { get; set; }
        public decimal? UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool Discontinued { get; set; }

        //Navigatipn Property
        //Bir ürünün(product) tek bir categorisi(category) ve tedarilçisi(supplier) var
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
