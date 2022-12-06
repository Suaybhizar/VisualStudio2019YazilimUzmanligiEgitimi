using ETicaret.DataAccess.Repositories;
using ETicaret.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETicaret.Business
{
    public class CategoryBs
    {
        private readonly CategoryRepository _repo;
        public CategoryBs()
        {
            _repo = new CategoryRepository();
        }

        public List<Category> GetCategories(params string[] includeList)
        {
            return _repo.GetAll(includeList: includeList);
        }
    }
}
