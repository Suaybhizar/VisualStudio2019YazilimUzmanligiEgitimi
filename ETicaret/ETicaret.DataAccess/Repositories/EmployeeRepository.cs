using ETicaret.DataAccess.Contexts;
using ETicaret.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ETicaret.DataAccess.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>
    {
        public List<Employee> GetByTitle(string title)
        {
            using (NorthwndContext ctx = new NorthwndContext())
            {
                return ctx.Employees.Where(e => e.Title == title).ToList();
            }
        }
    }
}
