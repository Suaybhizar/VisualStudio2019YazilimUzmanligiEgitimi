using FreshShop.Business.Abstract;
using FreshShop.DataAccess.Abstract;
using FreshShop.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreshShop.Business.Concrete
{

    //TIGHTLY COUPLED (SIKI SIKIYA BAGLI)
    //LOOSELY COUPLED (GEVŞEK BAGLI)
    //SOLID

    //DEPENDENCY INJECTION (BAGIMLILIGIN DIŞARDAN ENJEKTE EDİLMESİ)
    public class ManagerBs : IManagerBs
    {
        private readonly IManagerRepository _repo;

        public ManagerBs(IManagerRepository repo) //constructor injection 
        {
            _repo = repo;
        }

        public void Delete(Manager entity)
        {
            _repo.Delete(entity);
        }

        public Manager Get(Expression<Func<Manager, bool>> filter)
        {
            return _repo.Get(filter);
        }

        public List<Manager> GetAll(Expression<Func<Manager, bool>> filter = null)
        {
            return _repo.GetAll(filter);

        }

        public Manager GetByEmail(string email)
        {
            return _repo.GetByEmail(email);
        }

        public Manager GetById(int id)
        {
            return _repo.GetById(id);

        }

        public int Insert(Manager entity)
        {
            return _repo.Insert(entity);
        }

        public Manager LogIn(string userName, string password)
        {
            return _repo.LogIn(userName, password);
        }

        public void Update(Manager entity)
        {
            _repo.Update(entity);
        }
    }
}