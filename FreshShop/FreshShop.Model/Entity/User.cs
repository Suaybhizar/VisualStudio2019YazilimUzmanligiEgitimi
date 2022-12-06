using System;
using System.Collections.Generic;
using System.Text;

namespace FreshShop.Model.Entity
{
    public class User : BaseEntity
    {
        public User()
        {
            Comments = new HashSet<ProductComment>();
        }

        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhotoPath { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RegisterDate { get; set; }

        public virtual ICollection<ProductComment> Comments { get; set; }

    }
}