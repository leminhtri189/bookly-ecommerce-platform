using BooklyShop.BusinessObject.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class User : BaseModel
    {        
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Avatar { get; set; }
        public UserRole Role { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }
        public virtual ICollection<Address>? Address { get; set; }
        public virtual ICollection<Transaction>? Transactions { get; set; }
    }
}
