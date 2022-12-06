using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Models.Entity
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Navigation Property
        //Bir Categorynin birden fazla ürünü var(product)
        //koleksiyonu uygulayabilmesi için boş bir koleksiyon tanımlanması gerekmektedir buda yukarıda constructor içerisinde HashSet ile yapılmıştır

        public virtual ICollection<Product> Products { get; set; }
    }
}
