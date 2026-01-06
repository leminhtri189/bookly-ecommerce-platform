using BooklyShop.BusinessObject.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class Cart : BaseModel
    {
        public CartStatus Status { get; set; }
        public ICollection<CartItem> CartItems{ get; set; }
    }
}
