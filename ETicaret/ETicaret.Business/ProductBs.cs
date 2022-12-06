using ETicaret.DataAccess.Repositories;
using ETicaret.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Business
{
    public class ProductBs
    {
        private readonly ProductRepository _repo;
        public ProductBs()
        {
            _repo = new ProductRepository();
        }
        public int Add(Product product)
        {
            //Authorization
            //Vallidation

            //Veri tabanuna Insert edilecek


            return _repo.Insert(product);
        }

        public List<Product> GetProducts(params string[] includeList)
        {
            return _repo.GetAll(includeList: includeList);
        }
    }
}
