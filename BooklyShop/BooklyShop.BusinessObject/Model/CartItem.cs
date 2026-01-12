using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class CartItem : BaseModel
    {
        public Guid CartId { get; set; }
        public Guid BookId { get; set; }
        public decimal Price { get; set; }
        public Books Books { get; set; }
        public int Quantity { get; set; }
        public virtual Cart Cart { get; set; }

    }
}
