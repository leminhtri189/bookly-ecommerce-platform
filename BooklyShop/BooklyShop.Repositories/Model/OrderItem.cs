using System;
using System.Collections.Generic;
using System.Text;

namespace BooklyShop.BusinessObject.Model
{
    public class OrderItem : BaseModel
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Books Book { get; set; }
    }
}
