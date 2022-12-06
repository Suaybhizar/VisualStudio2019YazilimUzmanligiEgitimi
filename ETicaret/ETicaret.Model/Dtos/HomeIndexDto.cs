using ETicaret.Model.Entities;
using System.Collections.Generic;

namespace ETicaret.Model.Dtos
{
    public class HomeIndexDto
    {
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }

    }
}

