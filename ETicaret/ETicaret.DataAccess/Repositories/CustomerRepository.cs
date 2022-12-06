using ETicaret.DataAccess.Contexts;
using ETicaret.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.DataAccess.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public List<Customer> GetByCountry(string countryName){
            using (NorthwndContext ctx = new NorthwndContext())
            {
                return ctx.Customers.Where(c => c.Country == countryName).ToList();
            }
        }
    }
}
