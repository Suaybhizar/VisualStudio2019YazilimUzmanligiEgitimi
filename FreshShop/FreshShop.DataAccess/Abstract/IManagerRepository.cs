
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.DataAccess.Abstract
{
    public interface IManagerRepository : IRepository<Manager>
    {
        Manager LogIn(string userName, string password);
        Manager GetByEmail(string email);
    }
}