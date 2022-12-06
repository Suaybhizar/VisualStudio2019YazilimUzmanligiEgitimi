using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Models.Entity
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }

        //Navigation Property
        //Bir tedarilçiye(supplier) ait birden fazla ürün(product) var
        //koleksiyonu uygulayabilmesi için boş bir koleksiyon tanımlanması gerekmektedir buda yukarıda constructor içerisinde HashSet ile yapılmıştır
        public virtual ICollection<Product> Products { get; set; } 
    }
}
